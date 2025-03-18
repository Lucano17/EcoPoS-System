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
    public partial class Facturacion : FormBase
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string seller = $"SELECT * FROM Usuarios WHERE id_user = {Login.Code}";
            DataSet ds;
            ds = Biblioteca.Herramientas(seller);
            SellerLabel.Text = ds.Tables[0].Rows[0]["username"].ToString().Trim();

        }

        private void GridCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void GridDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void GridPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void GridQuantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void GridAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SellerLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(ClientCodeTextBox.Text.Trim()) == false)
                {
                    string cmd = string.Format($"SELECT Nombre_cliente FROM Clientes WHERE ID_clientes = '{ClientCodeTextBox.Text.Trim()}'");
                    DataSet ds = Biblioteca.Herramientas(cmd);
                    ClientLabel.Text = ds.Tables[0].Rows[0]["Nombre_cliente"].ToString().Trim();

                    ProductCodeTextBox.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error", error.Message);
            }
        }

        private void ClientCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
