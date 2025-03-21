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
    public partial class Ventas : Consultas
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ShowInfo("Facturas").Tables[0];

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
