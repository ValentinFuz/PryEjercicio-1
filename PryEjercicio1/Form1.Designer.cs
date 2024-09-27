namespace PryEjercicio1
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightCyan;
            this.btnAgregar.Location = new System.Drawing.Point(43, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 68);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEjercicio1.Properties.Resources.Diseño_sin_título_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(210, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 210);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightCyan;
            this.btnModificar.Location = new System.Drawing.Point(43, 156);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(126, 68);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscar.Location = new System.Drawing.Point(451, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 68);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar Producto";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCyan;
            this.btnEliminar.Location = new System.Drawing.Point(451, 156);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 68);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "¡Bienvenido a su gestor de inventario de preferencia!";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.LightCyan;
            this.btnMostrar.Location = new System.Drawing.Point(210, 283);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(160, 33);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Crear reporte y Mostrar Lista";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(43, 347);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(534, 104);
            this.dgvGrilla.TabIndex = 11;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(611, 474);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvGrilla;
    }
}

