using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEjercicio1
{
    public partial class frmInicio : Form
    {
        
        public frmInicio()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        ConexionBD conexion = new ConexionBD();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvGrilla.Columns.Clear();
            conexion.CargarBD(dgvGrilla);
            conexion.CrearReporte(dgvGrilla);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar frm = new frmModificar();
            frm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar frmBuscar = new frmBuscar();
            frmBuscar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar();
            frm.ShowDialog();
        }
    }
}
