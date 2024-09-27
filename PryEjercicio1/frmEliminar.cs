using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEjercicio1
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }
        ConexionBD conexion = new ConexionBD();

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text != null)
            {
                btnEliminar.Enabled = true;

            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(conexion.verificarNombre(txtNom.Text))
            {
                dgvGrilla.Columns.Clear();

                DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas agregar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {


                    MessageBox.Show("Has seleccionado Sí.");
                    conexion.EliminarUsuario(txtNom.Text);
                    conexion.CargarBD(dgvGrilla);
                    btnEliminar.Enabled = false;
                    txtNom.Text = "";
                }
                else if (result == DialogResult.No)
                {

                    MessageBox.Show("Has seleccionado No.");
                }
            }
            else
            {
                MessageBox.Show("El nombre seleccionado no existe en la base de datos.");
                btnEliminar.Enabled = false;
                txtNom.Text = "";
            }
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
