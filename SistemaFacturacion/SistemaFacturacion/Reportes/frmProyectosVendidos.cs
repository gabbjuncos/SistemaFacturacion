﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Reportes
{
    public partial class frmProyectosVendidos : Form
    {
        public frmProyectosVendidos()
        {
            InitializeComponent();
        }

        private void frmProyectosVendidos_Load(object sender, EventArgs e)
        {

            this.rpvEstadisticaProyectosVendidos.RefreshReport();
        }
    }
}
