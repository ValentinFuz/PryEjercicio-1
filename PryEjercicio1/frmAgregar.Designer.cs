namespace PryEjercicio1
{
    partial class frmAgregar
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
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxDesc = new System.Windows.Forms.RichTextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrec);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.numStock);
            this.groupBox1.Controls.Add(this.cmbCateg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rtxDesc);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos a Agregar";
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(386, 123);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(137, 24);
            this.txtPrec.TabIndex = 9;
            this.txtPrec.TextChanged += new System.EventHandler(this.txtPrec_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightCyan;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(242, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(173, 137);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(49, 24);
            this.numStock.TabIndex = 6;
            this.numStock.ValueChanged += new System.EventHandler(this.numStock_ValueChanged);
            // 
            // cmbCateg
            // 
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Location = new System.Drawing.Point(128, 86);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(137, 23);
            this.cmbCateg.TabIndex = 5;
            this.cmbCateg.SelectedIndexChanged += new System.EventHandler(this.cmbCateg_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoría:";
            // 
            // rtxDesc
            // 
            this.rtxDesc.Location = new System.Drawing.Point(386, 37);
            this.rtxDesc.Name = "rtxDesc";
            this.rtxDesc.Size = new System.Drawing.Size(137, 64);
            this.rtxDesc.TabIndex = 3;
            this.rtxDesc.Text = "";
            this.rtxDesc.TextChanged += new System.EventHandler(this.rtxDesc_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(128, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(137, 24);
            this.txtNom.TabIndex = 2;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lista";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(35, 266);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(549, 132);
            this.dgvGrilla.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightCyan;
            this.btnVolver.Location = new System.Drawing.Point(504, 421);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 32);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(624, 465);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.ComboBox cmbCateg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxDesc;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnVolver;
    }
}