namespace crud_conexion_BD
{
    partial class frm1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.img_crear = new System.Windows.Forms.PictureBox();
            this.img_actualizar = new System.Windows.Forms.PictureBox();
            this.img_eliminar = new System.Windows.Forms.PictureBox();
            this.img_editar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_crear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_editar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 37);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 189);
            this.dataGridView1.TabIndex = 5;
            // 
            // img_crear
            // 
            this.img_crear.BackColor = System.Drawing.Color.Black;
            this.img_crear.Image = global::crud_conexion_BD.Properties.Resources.crear;
            this.img_crear.Location = new System.Drawing.Point(26, 57);
            this.img_crear.Name = "img_crear";
            this.img_crear.Size = new System.Drawing.Size(48, 34);
            this.img_crear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_crear.TabIndex = 0;
            this.img_crear.TabStop = false;
            // 
            // img_actualizar
            // 
            this.img_actualizar.Image = global::crud_conexion_BD.Properties.Resources.actualizar;
            this.img_actualizar.Location = new System.Drawing.Point(228, 57);
            this.img_actualizar.Name = "img_actualizar";
            this.img_actualizar.Size = new System.Drawing.Size(49, 35);
            this.img_actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_actualizar.TabIndex = 3;
            this.img_actualizar.TabStop = false;
            // 
            // img_eliminar
            // 
            this.img_eliminar.Image = global::crud_conexion_BD.Properties.Resources.eliminar1;
            this.img_eliminar.Location = new System.Drawing.Point(148, 58);
            this.img_eliminar.Name = "img_eliminar";
            this.img_eliminar.Size = new System.Drawing.Size(74, 34);
            this.img_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_eliminar.TabIndex = 2;
            this.img_eliminar.TabStop = false;
            // 
            // img_editar
            // 
            this.img_editar.Image = global::crud_conexion_BD.Properties.Resources.editar;
            this.img_editar.Location = new System.Drawing.Point(80, 58);
            this.img_editar.Name = "img_editar";
            this.img_editar.Size = new System.Drawing.Size(62, 34);
            this.img_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_editar.TabIndex = 1;
            this.img_editar.TabStop = false;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(432, 321);
            this.Controls.Add(this.img_crear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_actualizar);
            this.Controls.Add(this.img_eliminar);
            this.Controls.Add(this.img_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm1";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_crear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_editar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_crear;
        private System.Windows.Forms.PictureBox img_editar;
        private System.Windows.Forms.PictureBox img_eliminar;
        private System.Windows.Forms.PictureBox img_actualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

