using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SistemaFacturacion.Listados;


namespace SistemaFacturacion.Reportes
{
    public partial class frmProductosVendidos : Form
    {
        public frmProductosVendidos()
        {
            InitializeComponent();
        }

        private void frmProductosVendidos_Load(object sender, EventArgs e)
        {



            this.reportViewer1.RefreshReport();
        }


    }
}
