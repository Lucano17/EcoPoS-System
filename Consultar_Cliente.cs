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
    }
}
