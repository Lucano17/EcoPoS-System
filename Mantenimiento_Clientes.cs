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
    public partial class Mantenimiento_Clientes : Mantenimiento
    {
        public Mantenimiento_Clientes()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Clientes_Load(object sender, EventArgs e)
        {

        }

        public override Boolean Guardar()
        {
            try
            {
                string insert = string.Format("EXEC ActualizarClientes " +
                    $"'{ClientIDTextBox.Text.Trim()}', " +
                    $"'{ClientNameTextBox.Text.Trim()}', " +
                    $"'{ClientLastNameTextBox.Text.Trim()}'");

                Biblioteca.Herramientas(insert);
                MessageBox.Show("Cliente guardado correctamente");
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
                string delete = string.Format("EXEC EliminarClientes " +
                    $"{ClientIDTextBox}");
                Biblioteca.Herramientas(delete);
                MessageBox.Show("Cliente eliminado correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error);
            }
        }

        private void ClientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientLastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientIDLabel_Click(object sender, EventArgs e)
        {

        }
        private void ClientNameLabel_Click(object sender, EventArgs e)
        {

        }
        private void ClientLastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Guardar();
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
