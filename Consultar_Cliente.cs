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
    public partial class Consultar_Cliente : Consultas
    {
        public Consultar_Cliente()
        {
            InitializeComponent();
        }

        private void Consultar_Cliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ShowInfo("Clientes").Tables[0];
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string buscar = "SELECT * FROM Clientes " +
                        "WHERE Nombre_cliente LIKE ('%" + textBox1.Text.Trim() + "%')";
                    DS = Biblioteca.Herramientas(buscar);
                    dataGridView1.DataSource = DS.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se puede conectar", error.Message);
                }
            }
        }
    }
}
