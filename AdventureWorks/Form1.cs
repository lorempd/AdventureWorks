using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorks
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListar listar = new frmListar();
            listar.ShowDialog();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrear crear = new frmCrear();
            crear.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizar actualizar = new frmActualizar();
            actualizar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar eliminar = new frmEliminar();
            eliminar.ShowDialog();
        }
    }
}
