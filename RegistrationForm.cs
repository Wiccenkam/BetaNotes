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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            this.CenterToScreen();
            InitializeComponent();

            userNameFieald.Text = "Enter your Name";
            userNameFieald.ForeColor = Color.Gray;
            loginField.Text = "Enter your login";
            loginField.ForeColor = Color.Gray;
            userSurnameField.Text = "Enter your surname";
            userSurnameField.ForeColor = Color.Gray;
            passField.Text = "Enter your password";
            passField.ForeColor = Color.Gray;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Green;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }
        Point rlastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - rlastPoint.X;
                this.Top += e.Y - rlastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            rlastPoint = new Point(e.X, e.Y);
        }

        private void userNameFieald_Enter(object sender, EventArgs e)
        {
            if(userNameFieald.Text == "Enter your Name" )
                userNameFieald.Text = string.Empty;
                userNameFieald.ForeColor = Color.Black;
        }

        private void userNameFieald_Leave(object sender, EventArgs e)
        {
            if (userNameFieald.Text == string.Empty)
                userNameFieald.Text = "Enter your Name";
                userNameFieald.ForeColor = Color.Gray;
        }

        private void userNameFieald_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            if (userNameFieald.Text == string.Empty | userNameFieald.Text == "Enter your Name")
                {
                    MessageBox.Show("Enter your Name");
                    return;
                }
            if (userSurnameField.Text == string.Empty | userSurnameField.Text == "Enter your surname")
                {
                    MessageBox.Show("Enter your surname");
                    return;
                }
            if (passField.Text == string.Empty | passField.Text == "Enter your password")
                {
                    MessageBox.Show("Enter your password");
                    return;
                }
            if (loginField.Text == string.Empty | loginField.Text == "Enter your login")
                {
                    MessageBox.Show("Enter your login");
                    return;
                }
            if (IsUserExist())
                return;



            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO users ( Login, Password, Name, Surname) VALUES (@login, @password, @name, @surname)", dB.getConnection()) ;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameFieald.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
            

            dB.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account was create");
            }
            else
            {
                MessageBox.Show("Some issue"); 
            }

            dB.CloseConnection();
           
        }

        private void buttonRegistrate_MouseEnter(object sender, EventArgs e)
        {
            buttonRegistrate.ForeColor = Color.Green;
        }

        private void buttonRegistrate_MouseLeave(object sender, EventArgs e)
        {
            buttonRegistrate.ForeColor = Color.Red;
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Enter your surname")
            {
                userSurnameField.Text = string.Empty;
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == string.Empty)
            {
                userSurnameField.Text = "Enter your surname";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == string.Empty)
            {
                loginField.Text = "Enter your login";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Enter your login")
            {
                loginField.Text = string.Empty;
                loginField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == string.Empty)
            {
                passField.Text = "Enter your password";
                passField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Enter your password")
            {
                passField.Text = string.Empty;
                passField.ForeColor = Color.Black;
            }
        }

        public Boolean IsUserExist()
        {
            DB database = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login`= @Login", database.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Same login already exist");
                return true;
            }
            else
            {
                MessageBox.Show("User not exist");
                return false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SwapForms_MouseEnter(object sender, EventArgs e)
        {
            SwapForms.ForeColor = Color.Green;
        }

        private void SwapForms_MouseLeave(object sender, EventArgs e)
        {
            SwapForms.ForeColor = Color.Black;
        }

        private void SwapForms_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginFormForm = new LoginForm();
            LoginFormForm.Show();
        }
    }
}
