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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }
        int numCat;
        ConexionBD conexion = new ConexionBD();

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;

            dgvGrilla.Columns.Clear();

            List<string> categorias = conexion.ImprimirCateg(cmbCateg);
            cmbCateg.Items.Clear();
            cmbCateg.Items.AddRange(categorias.ToArray());
            numStock.Value = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text != null && cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != null && txtPrec.Text != null)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void cmbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cate = cmbCateg.SelectedItem.ToString();
            numCat = conexion.DevolverId(cate);

            if (txtNom.Text != null && cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != null && txtPrec.Text != null)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void numStock_ValueChanged(object sender, EventArgs e)
        {
            if (txtNom.Text != null && cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != null && txtPrec.Text != null)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void rtxDesc_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text != null && cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != null && txtPrec.Text != null)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtPrec_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text != null && cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != null && txtPrec.Text != null)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!conexion.verificarNombre(txtNom.Text))
            {
                dgvGrilla.Columns.Clear();

                DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas agregar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("Has seleccionado Sí.");
                    conexion.CrearEnBD(txtNom.Text, numCat, Convert.ToInt32(numStock.Value), rtxDesc.Text, Convert.ToInt32(txtPrec.Text));
                    conexion.CargarBD(dgvGrilla);

                    txtNom.Text = "";
                    numStock.Value = 0;
                    rtxDesc.Text = "";
                    txtPrec.Text = "";

                    cmbCateg.Enabled = false;
                    numStock.Enabled = false;
                    rtxDesc.Enabled = false;
                    txtPrec.Enabled = false;
                    btnAgregar.Enabled = false;
                }
                else if (result == DialogResult.No)
                {

                    MessageBox.Show("Has seleccionado No.");
                }
            }
            else
            {
                MessageBox.Show("¡Cuidado, ese nombre ya existe!");
                txtNom.Text = "";
                btnAgregar.Enabled = false;
            }
        }
    }
}
