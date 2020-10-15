using System;
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
    public partial class frmUsuarioProductosVendidos : Form
    {
        public frmUsuarioProductosVendidos()
        {
            InitializeComponent();
        }

        private void frmUsuarioProductosVendidos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
