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
    public partial class FrmLogin : Form
    {
        public UsuariosEe objUsuario = new UsuariosEe();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuariosEe Usuario = new UsuariosEe();
            Usuario.Usuario = txtUsuario.Text;
            Usuario.Pass = txtPass.Text;
            objUsuario = Usuario;
            this.Close();
            FrmPrincipal frm = new FrmPrincipal();
            frm.objUsuario = Usuario;
            
            this.Close();
        }
    }
}
