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
            this.dgv_mostrar_registros = new System.Windows.Forms.DataGridView();
            this.img_crear = new System.Windows.Forms.PictureBox();
            this.img_actualizar = new System.Windows.Forms.PictureBox();
            this.img_eliminar = new System.Windows.Forms.PictureBox();
            this.img_editar = new System.Windows.Forms.PictureBox();
            this.btn_primer_registro = new System.Windows.Forms.Button();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_registro_anterior = new System.Windows.Forms.Button();
            this.btn_registro_siguiente = new System.Windows.Forms.Button();
            this.btn_ultimo_registro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_registros)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(474, 37);
            this.panel1.TabIndex = 4;
            // 
            // dgv_mostrar_registros
            // 
            this.dgv_mostrar_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar_registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nombre_usuario,
            this.apellido_usuario,
            this.edad_usuario});
            this.dgv_mostrar_registros.Location = new System.Drawing.Point(12, 120);
            this.dgv_mostrar_registros.Name = "dgv_mostrar_registros";
            this.dgv_mostrar_registros.Size = new System.Drawing.Size(353, 189);
            this.dgv_mostrar_registros.TabIndex = 5;
            this.dgv_mostrar_registros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mostrar_registros_CellContentClick);
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
            // btn_primer_registro
            // 
            this.btn_primer_registro.Location = new System.Drawing.Point(80, 315);
            this.btn_primer_registro.Name = "btn_primer_registro";
            this.btn_primer_registro.Size = new System.Drawing.Size(32, 23);
            this.btn_primer_registro.TabIndex = 6;
            this.btn_primer_registro.Text = "<<";
            this.btn_primer_registro.UseVisualStyleBackColor = true;
            this.btn_primer_registro.Click += new System.EventHandler(this.btn_primer_registro_Click);
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID";
            this.id_usuario.Name = "id_usuario";
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.HeaderText = "Nombre";
            this.nombre_usuario.Name = "nombre_usuario";
            // 
            // apellido_usuario
            // 
            this.apellido_usuario.HeaderText = "Apellido";
            this.apellido_usuario.Name = "apellido_usuario";
            // 
            // edad_usuario
            // 
            this.edad_usuario.HeaderText = "Edad";
            this.edad_usuario.Name = "edad_usuario";
            // 
            // btn_registro_anterior
            // 
            this.btn_registro_anterior.Location = new System.Drawing.Point(133, 315);
            this.btn_registro_anterior.Name = "btn_registro_anterior";
            this.btn_registro_anterior.Size = new System.Drawing.Size(32, 23);
            this.btn_registro_anterior.TabIndex = 7;
            this.btn_registro_anterior.Text = "<";
            this.btn_registro_anterior.UseVisualStyleBackColor = true;
            this.btn_registro_anterior.Click += new System.EventHandler(this.btn_registro_anterior_Click);
            // 
            // btn_registro_siguiente
            // 
            this.btn_registro_siguiente.Location = new System.Drawing.Point(190, 315);
            this.btn_registro_siguiente.Name = "btn_registro_siguiente";
            this.btn_registro_siguiente.Size = new System.Drawing.Size(32, 23);
            this.btn_registro_siguiente.TabIndex = 8;
            this.btn_registro_siguiente.Text = ">";
            this.btn_registro_siguiente.UseVisualStyleBackColor = true;
            this.btn_registro_siguiente.Click += new System.EventHandler(this.btn_registro_siguiente_Click);
            // 
            // btn_ultimo_registro
            // 
            this.btn_ultimo_registro.Location = new System.Drawing.Point(245, 315);
            this.btn_ultimo_registro.Name = "btn_ultimo_registro";
            this.btn_ultimo_registro.Size = new System.Drawing.Size(32, 23);
            this.btn_ultimo_registro.TabIndex = 9;
            this.btn_ultimo_registro.Text = ">>";
            this.btn_ultimo_registro.UseVisualStyleBackColor = true;
            this.btn_ultimo_registro.Click += new System.EventHandler(this.btn_ultimo_registro_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(474, 363);
            this.Controls.Add(this.btn_ultimo_registro);
            this.Controls.Add(this.btn_registro_siguiente);
            this.Controls.Add(this.btn_registro_anterior);
            this.Controls.Add(this.btn_primer_registro);
            this.Controls.Add(this.img_crear);
            this.Controls.Add(this.dgv_mostrar_registros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_actualizar);
            this.Controls.Add(this.img_eliminar);
            this.Controls.Add(this.img_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm1";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_registros)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_mostrar_registros;
        private System.Windows.Forms.Button btn_primer_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad_usuario;
        private System.Windows.Forms.Button btn_registro_anterior;
        private System.Windows.Forms.Button btn_registro_siguiente;
        private System.Windows.Forms.Button btn_ultimo_registro;
    }
}

