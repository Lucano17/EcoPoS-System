﻿using System;
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
    public partial class Mantenimiento : FormBase
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }
        private void RequestButton_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void NewButton_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Eliminar();
        }


    }
}
