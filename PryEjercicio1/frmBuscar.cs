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
    public partial class frmBuscar : Form
    {
        ConexionBD conexion = new ConexionBD();
        int numCat;
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text.Length > 0)
            {
                btnBuscarNom.Enabled = true;

            }
            else
            {
                btnBuscarNom.Enabled = false;
            }
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            List<string> categorias = conexion.ImprimirCateg(cmbCateg);
            cmbCateg.Items.Clear();
            cmbCateg.Items.AddRange(categorias.ToArray());
        }

        private void btnBuscarCat_Click(object sender, EventArgs e)
        {
            dgvGrilla.Columns.Clear();

            DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas Buscar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Has seleccionado Sí.");
                conexion.ImprimirPorCat(dgvGrilla, cmbCateg.SelectedItem.ToString());
                btnBuscarCat.Enabled = false;
            }
            else if (result == DialogResult.No)
            {

                MessageBox.Show("Has seleccionado No.");
            }
        }

        private void cmbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cate = cmbCateg.SelectedItem.ToString();
            numCat = conexion.DevolverId(cate);
            if (cmbCateg.SelectedItem != null)
            {
                btnBuscarCat.Enabled = true;
            }
            else
            {
                btnBuscarCat.Enabled = false;
            }
        }

        private void btnBuscarNom_Click(object sender, EventArgs e)
        {
            dgvGrilla.Columns.Clear();

                DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas Buscar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("Has seleccionado Sí.");
                    conexion.ImprimirPorNombre(dgvGrilla, txtNom.Text);
                    txtNom.Text = "";
                    btnBuscarNom.Enabled = false;
                }
                else if (result == DialogResult.No)
                {

                    MessageBox.Show("Has seleccionado No.");
                }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if(txtCod.Text != null)
            {
                btnBuscarCod.Enabled = true;
            }
            else
            {
                btnBuscarCod.Enabled = false;
            }
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            dgvGrilla.Columns.Clear();

            DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas Buscar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Has seleccionado Sí.");
                conexion.ImprimirPorCod(dgvGrilla, txtCod.Text);
                txtCod.Text = "";
                btnBuscarCod.Enabled = false;
            }
            else if (result == DialogResult.No)
            {

                MessageBox.Show("Has seleccionado No.");
            }
        }
    }
}
