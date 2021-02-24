//using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.CenterToScreen();
            InitializeComponent();
            TextBoxLogin.Text = "Enter your login";
            TextBoxLogin.ForeColor = Color.Gray;
            TextBoxPassword.Text = "Enter your password";
            TextBoxPassword.ForeColor = Color.Gray;
            
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.Green;
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.Red;
        }
        Point lastPoint;
        
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LoginUserr = TextBoxLogin.Text;
            string PassUser = TextBoxPassword.Text;

            DB database = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login`= @Login AND `Password`= @Pass", database.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginUserr;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User allready exist");
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("User not exist");
            }
            User.loginUser(LoginUserr);
        }
        public  string returnLogin()
        {
            string userLoGin = TextBoxLogin.Text;
            return userLoGin;
        }
        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.ForeColor = Color.Red;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.ForeColor = Color.Black;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BackPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void TextBoxLogin_Leave(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text == string.Empty)
            {
                TextBoxLogin.Text = "Enter your login";
                TextBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void TextBoxLogin_Enter(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text == "Enter your login")
            {
                TextBoxLogin.Text = string.Empty;
                TextBoxLogin.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == string.Empty)
            {
                TextBoxPassword.Text = "Enter your password";
                TextBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "Enter your password")
            {
                TextBoxPassword.Text = string.Empty;
                TextBoxPassword.ForeColor = Color.Black;
            }
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
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void SwapForms_MouseEnter_1(object sender, EventArgs e)
        {
            SwapForms.ForeColor = Color.Green;
        }

        private void SwapForms_MouseLeave_1(object sender, EventArgs e)
        {
            SwapForms.ForeColor = Color.Black;
        }
    }
}
