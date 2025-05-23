﻿namespace PryGestionDeInventario
{
    partial class frmAgregarProducto
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.updStock = new System.Windows.Forms.NumericUpDown();
            this.updPrecio = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.updCodigo = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.mrcIngresarDatos = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCodigo)).BeginInit();
            this.mrcIngresarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(13, 305);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(891, 373);
            this.dgvProductos.TabIndex = 31;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(700, 262);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(123, 180);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(501, 40);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // updStock
            // 
            this.updStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updStock.Location = new System.Drawing.Point(513, 90);
            this.updStock.Margin = new System.Windows.Forms.Padding(4);
            this.updStock.Name = "updStock";
            this.updStock.Size = new System.Drawing.Size(111, 22);
            this.updStock.TabIndex = 2;
            this.updStock.ValueChanged += new System.EventHandler(this.updStock_ValueChanged);
            // 
            // updPrecio
            // 
            this.updPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updPrecio.Location = new System.Drawing.Point(301, 90);
            this.updPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.updPrecio.Name = "updPrecio";
            this.updPrecio.Size = new System.Drawing.Size(107, 22);
            this.updPrecio.TabIndex = 1;
            this.updPrecio.ValueChanged += new System.EventHandler(this.updPrecio_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Descripción:";
            // 
            // updCodigo
            // 
            this.updCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updCodigo.Location = new System.Drawing.Point(123, 91);
            this.updCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.updCodigo.Name = "updCodigo";
            this.updCodigo.Size = new System.Drawing.Size(75, 22);
            this.updCodigo.TabIndex = 0;
            this.updCodigo.ValueChanged += new System.EventHandler(this.updCodigo_ValueChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(372, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Categoría:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(243, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Precio:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(123, 137);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(461, 91);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Stock:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(444, 137);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(180, 24);
            this.cmbCategoria.TabIndex = 4;
            this.cmbCategoria.Text = "Seleccionar categoría...";
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            this.cmbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoria_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Código:";
            // 
            // lblAviso
            // 
            this.lblAviso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Lavender;
            this.lblAviso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(123, 34);
            this.lblAviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(421, 36);
            this.lblAviso.TabIndex = 13;
            this.lblAviso.Text = ">>  Para agregar un producto, completar los campos  <<\r\nNo puede repetir un mismo" +
    " código";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mrcIngresarDatos
            // 
            this.mrcIngresarDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mrcIngresarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(158)))), ((int)(((byte)(88)))));
            this.mrcIngresarDatos.Controls.Add(this.lblAviso);
            this.mrcIngresarDatos.Controls.Add(this.label8);
            this.mrcIngresarDatos.Controls.Add(this.cmbCategoria);
            this.mrcIngresarDatos.Controls.Add(this.label13);
            this.mrcIngresarDatos.Controls.Add(this.txtNombre);
            this.mrcIngresarDatos.Controls.Add(this.label12);
            this.mrcIngresarDatos.Controls.Add(this.label11);
            this.mrcIngresarDatos.Controls.Add(this.updCodigo);
            this.mrcIngresarDatos.Controls.Add(this.label10);
            this.mrcIngresarDatos.Controls.Add(this.label9);
            this.mrcIngresarDatos.Controls.Add(this.updPrecio);
            this.mrcIngresarDatos.Controls.Add(this.updStock);
            this.mrcIngresarDatos.Controls.Add(this.txtDescripcion);
            this.mrcIngresarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngresarDatos.Location = new System.Drawing.Point(104, 14);
            this.mrcIngresarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.mrcIngresarDatos.Name = "mrcIngresarDatos";
            this.mrcIngresarDatos.Padding = new System.Windows.Forms.Padding(4);
            this.mrcIngresarDatos.Size = new System.Drawing.Size(696, 241);
            this.mrcIngresarDatos.TabIndex = 32;
            this.mrcIngresarDatos.TabStop = false;
            this.mrcIngresarDatos.Text = "Ingresar datos...";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(104, 262);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(67, 28);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolver.BackgroundImage = global::PryGestionDeInventario.Properties.Resources.go_back;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(13, 14);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(42, 36);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 690);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.mrcIngresarDatos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAgregarProducto";
            this.Text = "frmAgregarProducto";
            this.Load += new System.EventHandler(this.frmAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCodigo)).EndInit();
            this.mrcIngresarDatos.ResumeLayout(false);
            this.mrcIngresarDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown updStock;
        private System.Windows.Forms.NumericUpDown updPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown updCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.GroupBox mrcIngresarDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}