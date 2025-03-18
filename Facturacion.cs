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

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public static double total;
        public static int contadorFila = 0;
        private void SetButton_Click(object sender, EventArgs e)
        {
            // TO-DO: Agregar referencia a librería .dll | ErrorTextBox component
            //Error: Al ingresar varias filas, no se agrega el monto, ni se calcula bien cuando lo hace

            //if (Biblioteca.ValidarFormulario(this, errorProvider) == false)
            //{

            bool exists = false;
            int numeroFila = 0;
            // TO-DO: Revisar las variables price & quantity y los Convert para hacer
            // un código más limpio
            //double productPrice = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value);
            //double productQuantity = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);

            // Verificar si el producto ya existe en el DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == ProductCodeTextBox.Text)
                {
                    exists = true;
                    numeroFila = fila.Index;
                    break;
                }
            }

            if (exists)
            {
                // Actualizar cantidad del producto ya existente
                int nuevaCantidad = Convert.ToInt32(dataGridView1.Rows[numeroFila].Cells[3].Value) +
                                    Convert.ToInt32(QuantityTextBox.Text);
                dataGridView1.Rows[numeroFila].Cells[3].Value = nuevaCantidad;

                // Calcular el monto (precio * nuevaCantidad)
                double precio = Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[2].Value);
                dataGridView1.Rows[numeroFila].Cells[4].Value = precio * nuevaCantidad;
            }
            else
            {
                // Agregar una nueva fila si el producto no existe
                double precio = Convert.ToDouble(PriceTextBox.Text);
                int cantidad = Convert.ToInt32(QuantityTextBox.Text);
                double monto = precio * cantidad;

                dataGridView1.Rows.Add(
                    ProductCodeTextBox.Text,
                    DescriptionTextBox.Text,
                    precio,
                    cantidad,
                    monto); // Se añade el monto correctamente

                contadorFila++;
            }
            //}
            total = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                total += Convert.ToDouble(fila.Cells[4].Value);

            }
            TotalPriceLabel.Text = "$" + total.ToString();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click1(object sender, EventArgs e)
        {

        }

        private void TotalPriceLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (contadorFila > 0)
            {
                total = total - (Convert.ToDouble(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index]
                    .Cells[4].Value));
                TotalPriceLabel.Text = "$" + total.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                contadorFila--;
            }
        }
    }
}
