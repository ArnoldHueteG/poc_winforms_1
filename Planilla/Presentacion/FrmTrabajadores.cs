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
    public partial class FrmTrabajadores : Form
    {
        public FrmTrabajadores()
        {
            InitializeComponent();
        }

        private void FrmTrabajadores_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = true;
            this.Text = "Registro y Consulta de Trabajadores";
        }


        #region Pantalla 1: Listar y buscar

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2Collapsed = false;
            this.Text = "Registrar Trabajadores";
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2Collapsed = false;
            this.Text = "Modificar Trabajadores";
        }


        #endregion

        #region Pantalla 2: Registrar y/o Modificar

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = true;
            this.Text = "Registro y Consulta de Trabajadores";
        }



        #endregion


    }
}
