namespace actividad_crud
{
    partial class Form1
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
            this.txtAgregar = new System.Windows.Forms.Label();
            this.txtEditar = new System.Windows.Forms.Label();
            this.txtBorrar = new System.Windows.Forms.Label();
            this.txtVer = new System.Windows.Forms.Label();
            this.picVer = new System.Windows.Forms.PictureBox();
            this.picBorrar = new System.Windows.Forms.PictureBox();
            this.picEditar = new System.Windows.Forms.PictureBox();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgregar
            // 
            this.txtAgregar.AutoSize = true;
            this.txtAgregar.Enabled = false;
            this.txtAgregar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregar.Location = new System.Drawing.Point(328, 81);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(78, 22);
            this.txtAgregar.TabIndex = 5;
            this.txtAgregar.Text = "Agregar";
            // 
            // txtEditar
            // 
            this.txtEditar.AutoSize = true;
            this.txtEditar.Enabled = false;
            this.txtEditar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditar.Location = new System.Drawing.Point(347, 168);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(59, 22);
            this.txtEditar.TabIndex = 7;
            this.txtEditar.Text = "Editar";
            // 
            // txtBorrar
            // 
            this.txtBorrar.AutoSize = true;
            this.txtBorrar.Enabled = false;
            this.txtBorrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrar.Location = new System.Drawing.Point(494, 168);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(62, 22);
            this.txtBorrar.TabIndex = 9;
            this.txtBorrar.Text = "Borrar";
            // 
            // txtVer
            // 
            this.txtVer.AutoSize = true;
            this.txtVer.Enabled = false;
            this.txtVer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVer.Location = new System.Drawing.Point(517, 81);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(39, 22);
            this.txtVer.TabIndex = 12;
            this.txtVer.Text = "Ver";
            // 
            // picVer
            // 
            this.picVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVer.Enabled = false;
            this.picVer.Location = new System.Drawing.Point(562, 72);
            this.picVer.Name = "picVer";
            this.picVer.Size = new System.Drawing.Size(45, 45);
            this.picVer.TabIndex = 11;
            this.picVer.TabStop = false;
            this.picVer.Click += new System.EventHandler(this.picVer_Click);
            // 
            // picBorrar
            // 
            this.picBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBorrar.Enabled = false;
            this.picBorrar.Location = new System.Drawing.Point(562, 156);
            this.picBorrar.Name = "picBorrar";
            this.picBorrar.Size = new System.Drawing.Size(45, 45);
            this.picBorrar.TabIndex = 8;
            this.picBorrar.TabStop = false;
            this.picBorrar.Click += new System.EventHandler(this.picBorrar_Click);
            // 
            // picEditar
            // 
            this.picEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditar.Enabled = false;
            this.picEditar.Location = new System.Drawing.Point(412, 156);
            this.picEditar.Name = "picEditar";
            this.picEditar.Size = new System.Drawing.Size(45, 45);
            this.picEditar.TabIndex = 6;
            this.picEditar.TabStop = false;
            this.picEditar.Click += new System.EventHandler(this.picEditar_Click);
            // 
            // picAgregar
            // 
            this.picAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAgregar.Enabled = false;
            this.picAgregar.Location = new System.Drawing.Point(412, 72);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(45, 45);
            this.picAgregar.TabIndex = 1;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.picAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::actividad_crud.Properties.Resources.gato;
            this.pictureBox1.Location = new System.Drawing.Point(30, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 277);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.picVer);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.picBorrar);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.picEditar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.picAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picAgregar;
        private System.Windows.Forms.Label txtAgregar;
        private System.Windows.Forms.Label txtEditar;
        private System.Windows.Forms.PictureBox picEditar;
        private System.Windows.Forms.Label txtBorrar;
        private System.Windows.Forms.PictureBox picBorrar;
        private System.Windows.Forms.Label txtVer;
        private System.Windows.Forms.PictureBox picVer;
    }
}

