namespace RentaCal
{
    partial class Ver
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
            this.dgvVer = new System.Windows.Forms.DataGridView();
            this.txtBuscarFiltro = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBfilt = new System.Windows.Forms.Button();
            this.cbBfilt = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbEditor = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbDisponibilidad = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.lbHolder = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).BeginInit();
            this.gbEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVer
            // 
            this.dgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer.Location = new System.Drawing.Point(222, 15);
            this.dgvVer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.RowHeadersWidth = 51;
            this.dgvVer.Size = new System.Drawing.Size(832, 524);
            this.dgvVer.TabIndex = 0;
            // 
            // txtBuscarFiltro
            // 
            this.txtBuscarFiltro.Location = new System.Drawing.Point(16, 15);
            this.txtBuscarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarFiltro.Name = "txtBuscarFiltro";
            this.txtBuscarFiltro.Size = new System.Drawing.Size(151, 22);
            this.txtBuscarFiltro.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(176, 15);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(35, 28);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "<-";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBfilt
            // 
            this.txtBfilt.Location = new System.Drawing.Point(16, 47);
            this.txtBfilt.Margin = new System.Windows.Forms.Padding(4);
            this.txtBfilt.Name = "txtBfilt";
            this.txtBfilt.Size = new System.Drawing.Size(195, 28);
            this.txtBfilt.TabIndex = 3;
            this.txtBfilt.Text = "Busqueda Filtrada";
            this.txtBfilt.UseVisualStyleBackColor = true;
            this.txtBfilt.Click += new System.EventHandler(this.txtBfilt_Click);
            // 
            // cbBfilt
            // 
            this.cbBfilt.FormattingEnabled = true;
            this.cbBfilt.Location = new System.Drawing.Point(16, 82);
            this.cbBfilt.Margin = new System.Windows.Forms.Padding(4);
            this.cbBfilt.Name = "cbBfilt";
            this.cbBfilt.Size = new System.Drawing.Size(193, 24);
            this.cbBfilt.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(18, 188);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbEditor
            // 
            this.gbEditor.Controls.Add(this.btnEliminar);
            this.gbEditor.Controls.Add(this.cbDisponibilidad);
            this.gbEditor.Controls.Add(this.btnCancel);
            this.gbEditor.Controls.Add(this.btnSave);
            this.gbEditor.Controls.Add(this.txtPrecio);
            this.gbEditor.Controls.Add(this.txtModelo);
            this.gbEditor.Controls.Add(this.txtMarca);
            this.gbEditor.Location = new System.Drawing.Point(16, 305);
            this.gbEditor.Name = "gbEditor";
            this.gbEditor.Size = new System.Drawing.Size(178, 254);
            this.gbEditor.TabIndex = 6;
            this.gbEditor.TabStop = false;
            this.gbEditor.Visible = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(6, 31);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(150, 22);
            this.txtMarca.TabIndex = 0;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(6, 82);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(150, 22);
            this.txtModelo.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(6, 129);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 22);
            this.txtPrecio.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(94, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 27);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbDisponibilidad
            // 
            this.cbDisponibilidad.FormattingEnabled = true;
            this.cbDisponibilidad.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado"});
            this.cbDisponibilidad.Location = new System.Drawing.Point(6, 173);
            this.cbDisponibilidad.Name = "cbDisponibilidad";
            this.cbDisponibilidad.Size = new System.Drawing.Size(151, 24);
            this.cbDisponibilidad.TabIndex = 6;
            this.cbDisponibilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDisponibilidad_KeyPress);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(119, 188);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(28, 231);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(151, 22);
            this.txtBuscador.TabIndex = 8;
            this.txtBuscador.Tag = "";
            this.txtBuscador.Visible = false;
            // 
            // lbHolder
            // 
            this.lbHolder.AutoSize = true;
            this.lbHolder.BackColor = System.Drawing.Color.Transparent;
            this.lbHolder.Enabled = false;
            this.lbHolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHolder.ForeColor = System.Drawing.Color.Black;
            this.lbHolder.Location = new System.Drawing.Point(28, 257);
            this.lbHolder.Name = "lbHolder";
            this.lbHolder.Size = new System.Drawing.Size(151, 16);
            this.lbHolder.TabIndex = 9;
            this.lbHolder.Text = "Colocar el id a modificar";
            this.lbHolder.Visible = false;
            this.lbHolder.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(31, 276);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "confirmar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 221);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 27);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 780);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lbHolder);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.gbEditor);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cbBfilt);
            this.Controls.Add(this.txtBfilt);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBuscarFiltro);
            this.Controls.Add(this.dgvVer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ver";
            this.Text = "Ver";
            this.Load += new System.EventHandler(this.Ver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).EndInit();
            this.gbEditor.ResumeLayout(false);
            this.gbEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVer;
        private System.Windows.Forms.TextBox txtBuscarFiltro;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button txtBfilt;
        private System.Windows.Forms.ComboBox cbBfilt;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbEditor;
        private System.Windows.Forms.ComboBox cbDisponibilidad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label lbHolder;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}