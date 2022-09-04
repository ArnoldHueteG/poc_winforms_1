using Planilla.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilla.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public UsuariosEe objUsuario = new UsuariosEe();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.MdiParent = this;                        
            frm.Show();
            if (frm.IsDisposed)
            {

            }
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            FrmTrabajadores frm = new FrmTrabajadores();
            frm.MdiParent = this;
            frm.Show();            
        }
    }
}
