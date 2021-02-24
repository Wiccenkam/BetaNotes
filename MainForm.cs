using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kursach2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OwnerNotes.Text = string.Empty;
        }

        private void LoadDescription_Click(object sender, EventArgs e)
        {
            DB database = new DB();

           

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT (`Description`) FROM `users` WHERE `Login`= @Login", database.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = User.login;
            adapter.SelectCommand = command;
            database.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
           
                
                // Пройти в цикле по записям и построить строку
                while (reader.Read())
                {
                    object id = reader.GetValue(0);
                    /*object name = reader.GetValue(1);
                    object age = reader.GetValue(2);*/
                    textBoxImport.Text = id.ToString();
                 }

                // Закрыть DataReader
                reader.Close();
            

            MySqlCommand commandd = new MySqlCommand("SELECT (`CreationDate`) FROM `users` WHERE `Login`= @Login", database.getConnection());
            commandd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = User.login;
            adapter.SelectCommand = commandd;
            
            MySqlDataReader readerr = commandd.ExecuteReader();
           
            // Пройти в цикле по записям и построить строку
            while (readerr.Read())
            {
                object curentdate = readerr.GetValue(0);
                textBoxExport.Text = "Creation time-" + curentdate.ToString();
            }
            // Закрыть DataReader
            readerr.Close();
            
            

            MySqlCommand commanddd = new MySqlCommand("SELECT (Name) FROM `users` WHERE `Login`= @Login", database.getConnection());
            commanddd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = User.login;
            adapter.SelectCommand = commanddd;
            
            using (MySqlDataReader readerrr = commanddd.ExecuteReader())
            {
                while (readerrr.Read())
                {
                    
                    object name = readerrr[0];
                    OwnerNotes.Text = "Welcome \t" + name.ToString();
                }
            }

            database.CloseConnection();
        }

        private void LoadDescription_MouseLeave(object sender, EventArgs e)
        {
            LoadDescription.ForeColor = Color.Black;
        }

        private void LoadDescription_MouseEnter(object sender, EventArgs e)
        {
            LoadDescription.ForeColor = Color.Green;
        }

        private void UpdateNotes_MouseLeave(object sender, EventArgs e)
        {
           UpdateNotes.ForeColor = Color.Black;
        }

        private void UpdateNotes_MouseEnter(object sender, EventArgs e)
        {
            UpdateNotes.ForeColor = Color.Green;
        }

        private void UpdateNotes_Click(object sender, EventArgs e)
        {
            object notes = textBoxImport.Text;
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE users SET Description=@Description WHERE Login=@Login", dB.getConnection());
            command.Parameters.Add("@Description", MySqlDbType.VarChar).Value = textBoxImport.Text;
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = User.login;



            dB.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update sucsessfuly");
            }
            else
            {
                MessageBox.Show("Some issue");
            }

            dB.CloseConnection();
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.Green;
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.Red;
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void textBoxExport_TextChanged(object sender, EventArgs e)
        {

        }

        private void Notes_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Notes_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
