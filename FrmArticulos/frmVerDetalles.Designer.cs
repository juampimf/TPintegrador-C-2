namespace FrmArticulos
{
    partial class frmVerDetalles
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVerDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblVerCategoria = new System.Windows.Forms.Label();
            this.lblVerMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(83, 232);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblVerDescripcion
            // 
            this.lblVerDescripcion.AutoSize = true;
            this.lblVerDescripcion.Location = new System.Drawing.Point(172, 232);
            this.lblVerDescripcion.Name = "lblVerDescripcion";
            this.lblVerDescripcion.Size = new System.Drawing.Size(0, 13);
            this.lblVerDescripcion.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(83, 147);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(83, 190);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblVerCategoria
            // 
            this.lblVerCategoria.AutoSize = true;
            this.lblVerCategoria.Location = new System.Drawing.Point(172, 190);
            this.lblVerCategoria.Name = "lblVerCategoria";
            this.lblVerCategoria.Size = new System.Drawing.Size(0, 13);
            this.lblVerCategoria.TabIndex = 6;
            // 
            // lblVerMarca
            // 
            this.lblVerMarca.AutoSize = true;
            this.lblVerMarca.Location = new System.Drawing.Point(172, 147);
            this.lblVerMarca.Name = "lblVerMarca";
            this.lblVerMarca.Size = new System.Drawing.Size(0, 13);
            this.lblVerMarca.TabIndex = 7;
            // 
            // frmVerDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 432);
            this.Controls.Add(this.lblVerMarca);
            this.Controls.Add(this.lblVerCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblVerDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmVerDetalles";
            this.Text = "frmVerDetalles";
            this.Load += new System.EventHandler(this.frmVerDetalles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblVerDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblVerCategoria;
        private System.Windows.Forms.Label lblVerMarca;
    }
}