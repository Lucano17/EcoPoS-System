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
    public partial class Consultar_Ventas : Consultas
    {
        public Consultar_Ventas()
        {
            InitializeComponent();
        }

        private void Consultar_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string buscar = "SELECT * FROM Factura " +
                        "WHERE nro_factura LIKE ('%" + textBox1.Text.Trim() + "%')";
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
