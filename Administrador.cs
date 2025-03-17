using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_Library;

namespace EcoPoS_System
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }


        private void AdminText_Click(object sender, EventArgs e)
        {

        }

        private void UserText_Click(object sender, EventArgs e)
        {

        }

        private void CodeText_Click(object sender, EventArgs e)
        {

        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }

        private void CodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            string requestCode = $"SELECT * FROM Usuarios WHERE " +
                $"id_user = {Login.Code}";
            DataSet data = Biblioteca.Herramientas(requestCode);

            AdminLabel.Text = data.Tables[0].Rows[0]["username"].
                ToString();
            UserLabel.Text = data.Tables[0].Rows[0]["account"].
                ToString();
            CodeLabel.Text = data.Tables[0].Rows[0]["id_user"].
                ToString();

            string image = data.Tables[0].Rows[0]["image"].
                ToString();

            pictureBox1.Image = Image.FromFile(image);
        }
    }
}
