namespace pryLujan_IEFI
{
    partial class frmAgregarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProductos));
            this.grpProductos = new System.Windows.Forms.GroupBox();
            this.lblIDprod = new System.Windows.Forms.Label();
            this.txtIdproducto = new System.Windows.Forms.TextBox();
            this.lblNombreprod = new System.Windows.Forms.Label();
            this.txtNombreproducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCategoriaproducto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProductos
            // 
            this.grpProductos.Controls.Add(this.pictureBox1);
            this.grpProductos.Controls.Add(this.lblProveedor);
            this.grpProductos.Controls.Add(this.txtProveedor);
            this.grpProductos.Controls.Add(this.lblCategoria);
            this.grpProductos.Controls.Add(this.txtCategoriaproducto);
            this.grpProductos.Controls.Add(this.txtPrecio);
            this.grpProductos.Controls.Add(this.lblPrecio);
            this.grpProductos.Controls.Add(this.txtCantidad);
            this.grpProductos.Controls.Add(this.lblCantidad);
            this.grpProductos.Controls.Add(this.txtNombreproducto);
            this.grpProductos.Controls.Add(this.lblNombreprod);
            this.grpProductos.Controls.Add(this.txtIdproducto);
            this.grpProductos.Controls.Add(this.lblIDprod);
            this.grpProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProductos.Location = new System.Drawing.Point(24, 12);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(793, 182);
            this.grpProductos.TabIndex = 0;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "Datos del PRODUCTO:";
            // 
            // lblIDprod
            // 
            this.lblIDprod.AutoSize = true;
            this.lblIDprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDprod.Location = new System.Drawing.Point(61, 44);
            this.lblIDprod.Name = "lblIDprod";
            this.lblIDprod.Size = new System.Drawing.Size(86, 15);
            this.lblIDprod.TabIndex = 0;
            this.lblIDprod.Text = "ID Producto:";
            // 
            // txtIdproducto
            // 
            this.txtIdproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdproducto.Location = new System.Drawing.Point(153, 43);
            this.txtIdproducto.Name = "txtIdproducto";
            this.txtIdproducto.Size = new System.Drawing.Size(164, 21);
            this.txtIdproducto.TabIndex = 1;
            // 
            // lblNombreprod
            // 
            this.lblNombreprod.AutoSize = true;
            this.lblNombreprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreprod.Location = new System.Drawing.Point(6, 87);
            this.lblNombreprod.Name = "lblNombreprod";
            this.lblNombreprod.Size = new System.Drawing.Size(147, 15);
            this.lblNombreprod.TabIndex = 2;
            this.lblNombreprod.Text = "Nombre del Producto:";
            // 
            // txtNombreproducto
            // 
            this.txtNombreproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreproducto.Location = new System.Drawing.Point(153, 84);
            this.txtNombreproducto.Name = "txtNombreproducto";
            this.txtNombreproducto.Size = new System.Drawing.Size(164, 21);
            this.txtNombreproducto.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 132);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(148, 15);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad que ingresa:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(153, 129);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(164, 21);
            this.txtCantidad.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(367, 46);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(107, 15);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio Unitario:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(480, 44);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(166, 21);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtCategoriaproducto
            // 
            this.txtCategoriaproducto.Location = new System.Drawing.Point(480, 87);
            this.txtCategoriaproducto.Name = "txtCategoriaproducto";
            this.txtCategoriaproducto.Size = new System.Drawing.Size(166, 21);
            this.txtCategoriaproducto.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(323, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(158, 15);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria del Producto:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(480, 129);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(166, 21);
            this.txtProveedor.TabIndex = 10;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(382, 132);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(92, 15);
            this.lblProveedor.TabIndex = 11;
            this.lblProveedor.Text = "Id Proveedor:";
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Location = new System.Drawing.Point(24, 200);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(198, 48);
            this.btnAgregarProd.TabIndex = 12;
            this.btnAgregarProd.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(24, 254);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(793, 245);
            this.dgvProductos.TabIndex = 13;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(619, 505);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(198, 36);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(829, 544);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnAgregarProd);
            this.Controls.Add(this.grpProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarProductos";
            this.Load += new System.EventHandler(this.frmAgregarProductos_Load);
            this.grpProductos.ResumeLayout(false);
            this.grpProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProductos;
        private System.Windows.Forms.TextBox txtCategoriaproducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtNombreproducto;
        private System.Windows.Forms.Label lblNombreprod;
        private System.Windows.Forms.TextBox txtIdproducto;
        private System.Windows.Forms.Label lblIDprod;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnVolver;
    }
}