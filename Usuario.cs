using DLL_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoPoS_System
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void NameText_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            string requestCode = $"SELECT * FROM Usuarios WHERE " +
                $"id_user = {Login.Code}";
            DataSet data = Biblioteca.Herramientas(requestCode);

            NameLabel.Text = data.Tables[0].Rows[0]["username"].
                ToString();
            UserLabel.Text = data.Tables[0].Rows[0]["account"].
                ToString();
            CodeLabel.Text = data.Tables[0].Rows[0]["id_user"].
                ToString();

            string image = data.Tables[0].Rows[0]["image"].
                ToString();

            pictureBox1.Image = Image.FromFile(image);
        }

        private void PrincipalButton_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal principalContainer = new ContenedorPrincipal();
            this.Hide();
            principalContainer.Show();
        }
    }
}
