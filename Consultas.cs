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
using EcoPoS_System;

namespace EcoPoS_System
{
    public partial class Consultas : FormBase
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet ShowInfo(string table)
        {
            DataSet DS;
            string cmd = string.Format($"SELECT * FROM {table}");
            DS = Biblioteca.Herramientas(cmd);
            return DS;
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectButton_Click_1(object sender, EventArgs e)
        {

        }

        private void Consultas_Load_1(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
