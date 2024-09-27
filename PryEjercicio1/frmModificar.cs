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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }
        ConexionBD conexion = new ConexionBD();
        int numCat;

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text != null)
            {
                cmbCateg.Enabled = true;
                numStock.Enabled = true;
                rtxDesc.Enabled = true;
                txtPrec.Enabled = true;

                if (cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != "" && txtPrec.Text != "")
                {
                    btnModificar.Enabled = true;
                }
                else
                {
                    btnModificar.Enabled = false;
                }
            }
            else
            {
                cmbCateg.Enabled = false;
                numStock.Enabled = false;
                rtxDesc.Enabled = false;
                txtPrec.Enabled = false;
            }
        }

        private void cmbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cate = cmbCateg.SelectedItem.ToString();
            numCat = conexion.DevolverId(cate);
            if (cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != "" && txtPrec.Text != "")
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }

        private void numStock_ValueChanged(object sender, EventArgs e)
        {
            if (cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != "" && txtPrec.Text != "")
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }

        private void rtxDesc_TextChanged(object sender, EventArgs e)
        {
            if (cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != "" && txtPrec.Text != "")
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }

        private void txtPrec_TextChanged(object sender, EventArgs e)
        {
            if (cmbCateg.SelectedItem != null && numStock.Value >= 0 && rtxDesc.Text != "" && txtPrec.Text != "")
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(conexion.verificarNombre(txtNom.Text))
            {
                DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas agregar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Has seleccionado Sí.");

                    conexion.ModificarTodo(txtNom.Text, numCat, Convert.ToInt32(numStock.Value), rtxDesc.Text, Convert.ToInt32(txtPrec.Text));
                    conexion.ImprimirPorNom(dgvGrilla, txtNom.Text);

                    cmbCateg.Enabled = false;
                    numStock.Enabled = false;
                    rtxDesc.Enabled = false;
                    txtPrec.Enabled = false;
                    btnModificar.Enabled = false;

                    numStock.Value = 0;
                    rtxDesc.Text = null;
                    txtPrec.Text = null;

                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Has seleccionado No.");
                }
            }
            else
            {
                MessageBox.Show("El nombre que agregó no se encuentra en la base de datos.");
                txtNom.Text = null;
                btnModificar.Enabled = false;
            }
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            List<string> categorias = conexion.ImprimirCateg(cmbCateg);
            cmbCateg.Items.Clear();
            cmbCateg.Items.AddRange(categorias.ToArray());
        }
    }
}
