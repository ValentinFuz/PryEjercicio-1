namespace PryEjercicio1
{
    partial class frmBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnBuscarNom = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.btnBuscarCat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.btnBuscarNom);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por nombre";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(36, 38);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(116, 24);
            this.txtNom.TabIndex = 12;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // btnBuscarNom
            // 
            this.btnBuscarNom.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarNom.Enabled = false;
            this.btnBuscarNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNom.Location = new System.Drawing.Point(57, 93);
            this.btnBuscarNom.Name = "btnBuscarNom";
            this.btnBuscarNom.Size = new System.Drawing.Size(79, 31);
            this.btnBuscarNom.TabIndex = 11;
            this.btnBuscarNom.Text = "Buscar";
            this.btnBuscarNom.UseVisualStyleBackColor = false;
            this.btnBuscarNom.Click += new System.EventHandler(this.btnBuscarNom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCod);
            this.groupBox2.Controls.Add(this.btnBuscarCod);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(254, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por Código";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(38, 37);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(110, 24);
            this.txtCod.TabIndex = 12;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarCod.Enabled = false;
            this.btnBuscarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCod.Location = new System.Drawing.Point(54, 93);
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.Size = new System.Drawing.Size(79, 31);
            this.btnBuscarCod.TabIndex = 11;
            this.btnBuscarCod.Text = "Buscar";
            this.btnBuscarCod.UseVisualStyleBackColor = false;
            this.btnBuscarCod.Click += new System.EventHandler(this.btnBuscarCod_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbCateg);
            this.groupBox3.Controls.Add(this.btnBuscarCat);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(478, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 139);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por Categoría";
            // 
            // cmbCateg
            // 
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Location = new System.Drawing.Point(33, 38);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(121, 23);
            this.cmbCateg.TabIndex = 12;
            this.cmbCateg.SelectedIndexChanged += new System.EventHandler(this.cmbCateg_SelectedIndexChanged);
            // 
            // btnBuscarCat
            // 
            this.btnBuscarCat.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarCat.Enabled = false;
            this.btnBuscarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCat.Location = new System.Drawing.Point(55, 93);
            this.btnBuscarCat.Name = "btnBuscarCat";
            this.btnBuscarCat.Size = new System.Drawing.Size(79, 31);
            this.btnBuscarCat.TabIndex = 11;
            this.btnBuscarCat.Text = "Buscar";
            this.btnBuscarCat.UseVisualStyleBackColor = false;
            this.btnBuscarCat.Click += new System.EventHandler(this.btnBuscarCat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Lista";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(51, 207);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(592, 138);
            this.dgvGrilla.TabIndex = 17;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightCyan;
            this.btnVolver.Location = new System.Drawing.Point(581, 367);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(51, 32);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(687, 411);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnBuscarNom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarCat;
        private System.Windows.Forms.ComboBox cmbCateg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnVolver;
    }
}