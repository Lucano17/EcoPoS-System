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
    public partial class Mantenimiento_Productos : Mantenimiento
    {
        public Mantenimiento_Productos()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Productos_Load(object sender, EventArgs e)
        {

        }

        public override Boolean Guardar()
        {
            try
            {
                string insert = string.Format("EXEC ActualizarProductos " +
                    $"'{ProductIDTextBox.Text.Trim()}', " +
                    $"'{ProductNameTextBox.Text.Trim()}', " +
                    $"'{ProductPriceTextBox.Text.Trim()}'");

                Biblioteca.Herramientas(insert);
                MessageBox.Show("Producto guardado correctamente");
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error);
                return false;
            }
        }

        public override void Eliminar()
        {
            try
            {
                string delete = string.Format("EXEC EliminarProductos " +
                    $"{ProductIDTextBox.Text.Trim()}");
                Biblioteca.Herramientas(delete);
                MessageBox.Show("Producto eliminado correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error);
            }
        }

        public override void Nuevo()
        {
            if (string.IsNullOrEmpty(ProductIDTextBox.Text.Trim()) == false &&
                string.IsNullOrEmpty(ProductNameTextBox.Text.Trim()) == false &&
                string.IsNullOrEmpty(ProductPriceTextBox.Text.Trim()) == false)
            {
                ProductIDTextBox.Text = "";
                ProductNameTextBox.Text = "";
                ProductPriceTextBox.Text = "";
            }
        }
        public override void Consultar()
        {
            Consultar_Productos ConsPro = new Consultar_Productos();
            ConsPro.Show();
        }

        private void ProductIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
