using Microsoft.Data.SqlClient;
using System;
using DLL_Library;
using System.Data;

namespace EcoPoS_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string validate = String.Format(
                    $"Select * FROM Usuarios WHERE " +
                    $"account='{UserTextBox.Text.Trim()}' " +
                    $"AND password = '{PasswordTextBox.Text.Trim()}'");
                DataSet connect = Biblioteca.Herramientas(validate);

                if (connect.Tables.Count > 0 && connect.Tables[0].Rows.Count > 0)
                {
                    string account = connect.Tables[0].Rows[0]["account"]
                        .ToString().Trim();
                    string password = connect.Tables[0].Rows[0]["password"]
                        .ToString().Trim();

                    if (account == UserTextBox.Text.Trim() &&
                        password == PasswordTextBox.Text.Trim())
                    {
                        if (Convert.ToBoolean(connect.Tables[0].Rows[0]["admin_validation"]
                            .ToString().Trim()) == true)
                        {
                            Administrador Admin = new Administrador();
                            this.Hide();
                            Admin.Show();
                        }
                        else
                        {
                            Usuario User = new Usuario();
                            this.Hide();
                            User.Show();
                        }
                        MessageBox.Show("Inicio de sesión correcto");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("No se ha ingresado un usuario válido", error.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
