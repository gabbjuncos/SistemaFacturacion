using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Listados
{
    public partial class frmReporteUsuariosResponsables : Form
    {
        public frmReporteUsuariosResponsables()
        {
            InitializeComponent();
        }

        private void frmReporteUsuariosResponsables_Load(object sender, EventArgs e)
        {

            this.rptUsuarioResponsable.RefreshReport();
        }
    }
}
