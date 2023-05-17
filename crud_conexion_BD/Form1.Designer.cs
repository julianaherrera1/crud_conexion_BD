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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimizar_form = new System.Windows.Forms.Button();
            this.btn_cerrar_formulario = new System.Windows.Forms.Button();
            this.dgv_mostrar_registros = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_crear = new System.Windows.Forms.PictureBox();
            this.img_eliminar = new System.Windows.Forms.PictureBox();
            this.img_editar = new System.Windows.Forms.PictureBox();
            this.btn_primer_registro = new System.Windows.Forms.Button();
            this.btn_registro_anterior = new System.Windows.Forms.Button();
            this.btn_registro_siguiente = new System.Windows.Forms.Button();
            this.btn_ultimo_registro = new System.Windows.Forms.Button();
            this.grp_datos_usuario = new System.Windows.Forms.GroupBox();
            this.txt_edad_usuario = new System.Windows.Forms.TextBox();
            this.lbl_linea_edad = new System.Windows.Forms.Label();
            this.txt_apellido_usuario = new System.Windows.Forms.TextBox();
            this.lbl_linea_apellido = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.lbl_linea_nombre = new System.Windows.Forms.Label();
            this.btn_guardar_datos = new System.Windows.Forms.Button();
            this.lbl_edad_usuario = new System.Windows.Forms.Label();
            this.lbl_apellido_usuario = new System.Windows.Forms.Label();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.grp_mostrar_datos = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.img_buscar_registro = new System.Windows.Forms.PictureBox();
            this.txt_buscar_registro = new System.Windows.Forms.TextBox();
            this.lbl_buscar_registro = new System.Windows.Forms.Label();
            this.lbl_linea_id = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_registros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_crear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_editar)).BeginInit();
            this.grp_datos_usuario.SuspendLayout();
            this.grp_mostrar_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_buscar_registro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_minimizar_form);
            this.panel1.Controls.Add(this.btn_cerrar_formulario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 45);
            this.panel1.TabIndex = 4;
            // 
            // btn_minimizar_form
            // 
            this.btn_minimizar_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar_form.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar_form.ForeColor = System.Drawing.Color.LightGray;
            this.btn_minimizar_form.Location = new System.Drawing.Point(563, 12);
            this.btn_minimizar_form.Name = "btn_minimizar_form";
            this.btn_minimizar_form.Size = new System.Drawing.Size(31, 26);
            this.btn_minimizar_form.TabIndex = 8;
            this.btn_minimizar_form.Text = "-";
            this.btn_minimizar_form.UseVisualStyleBackColor = true;
            this.btn_minimizar_form.Click += new System.EventHandler(this.btn_minimizar_form_Click);
            // 
            // btn_cerrar_formulario
            // 
            this.btn_cerrar_formulario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cerrar_formulario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cerrar_formulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_formulario.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_formulario.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cerrar_formulario.Location = new System.Drawing.Point(603, 12);
            this.btn_cerrar_formulario.Name = "btn_cerrar_formulario";
            this.btn_cerrar_formulario.Size = new System.Drawing.Size(31, 26);
            this.btn_cerrar_formulario.TabIndex = 9;
            this.btn_cerrar_formulario.Text = "X";
            this.btn_cerrar_formulario.UseVisualStyleBackColor = true;
            this.btn_cerrar_formulario.Click += new System.EventHandler(this.btn_cerrar_formulario_Click);
            // 
            // dgv_mostrar_registros
            // 
            this.dgv_mostrar_registros.AllowUserToAddRows = false;
            this.dgv_mostrar_registros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mostrar_registros.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_mostrar_registros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_mostrar_registros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_mostrar_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar_registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nombre_usuario,
            this.apellido_usuario,
            this.edad_usuario});
            this.dgv_mostrar_registros.Location = new System.Drawing.Point(11, 22);
            this.dgv_mostrar_registros.Name = "dgv_mostrar_registros";
            this.dgv_mostrar_registros.Size = new System.Drawing.Size(491, 61);
            this.dgv_mostrar_registros.TabIndex = 5;
            this.dgv_mostrar_registros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mostrar_registros_CellContentClick);
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
            // img_crear
            // 
            this.img_crear.BackColor = System.Drawing.Color.Black;
            this.img_crear.Image = global::crud_conexion_BD.Properties.Resources.crear;
            this.img_crear.Location = new System.Drawing.Point(22, 62);
            this.img_crear.Name = "img_crear";
            this.img_crear.Size = new System.Drawing.Size(48, 34);
            this.img_crear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_crear.TabIndex = 0;
            this.img_crear.TabStop = false;
            this.img_crear.Click += new System.EventHandler(this.img_crear_Click);
            // 
            // img_eliminar
            // 
            this.img_eliminar.Image = global::crud_conexion_BD.Properties.Resources.eliminar1;
            this.img_eliminar.Location = new System.Drawing.Point(144, 63);
            this.img_eliminar.Name = "img_eliminar";
            this.img_eliminar.Size = new System.Drawing.Size(74, 34);
            this.img_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_eliminar.TabIndex = 2;
            this.img_eliminar.TabStop = false;
            this.img_eliminar.Click += new System.EventHandler(this.img_eliminar_Click);
            // 
            // img_editar
            // 
            this.img_editar.Image = global::crud_conexion_BD.Properties.Resources.editar;
            this.img_editar.Location = new System.Drawing.Point(76, 63);
            this.img_editar.Name = "img_editar";
            this.img_editar.Size = new System.Drawing.Size(62, 34);
            this.img_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_editar.TabIndex = 1;
            this.img_editar.TabStop = false;
            this.img_editar.Click += new System.EventHandler(this.img_editar_Click);
            // 
            // btn_primer_registro
            // 
            this.btn_primer_registro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_primer_registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_primer_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primer_registro.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_primer_registro.ForeColor = System.Drawing.Color.LightGray;
            this.btn_primer_registro.Location = new System.Drawing.Point(262, 126);
            this.btn_primer_registro.Name = "btn_primer_registro";
            this.btn_primer_registro.Size = new System.Drawing.Size(42, 31);
            this.btn_primer_registro.TabIndex = 6;
            this.btn_primer_registro.Text = "<<";
            this.btn_primer_registro.UseVisualStyleBackColor = true;
            this.btn_primer_registro.Click += new System.EventHandler(this.btn_primer_registro_Click);
            // 
            // btn_registro_anterior
            // 
            this.btn_registro_anterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_registro_anterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_registro_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro_anterior.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro_anterior.ForeColor = System.Drawing.Color.LightGray;
            this.btn_registro_anterior.Location = new System.Drawing.Point(310, 126);
            this.btn_registro_anterior.Name = "btn_registro_anterior";
            this.btn_registro_anterior.Size = new System.Drawing.Size(42, 31);
            this.btn_registro_anterior.TabIndex = 7;
            this.btn_registro_anterior.Text = "<";
            this.btn_registro_anterior.UseVisualStyleBackColor = true;
            this.btn_registro_anterior.Click += new System.EventHandler(this.btn_registro_anterior_Click);
            // 
            // btn_registro_siguiente
            // 
            this.btn_registro_siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_registro_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_registro_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro_siguiente.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro_siguiente.ForeColor = System.Drawing.Color.LightGray;
            this.btn_registro_siguiente.Location = new System.Drawing.Point(358, 126);
            this.btn_registro_siguiente.Name = "btn_registro_siguiente";
            this.btn_registro_siguiente.Size = new System.Drawing.Size(42, 31);
            this.btn_registro_siguiente.TabIndex = 8;
            this.btn_registro_siguiente.Text = ">";
            this.btn_registro_siguiente.UseVisualStyleBackColor = true;
            this.btn_registro_siguiente.Click += new System.EventHandler(this.btn_registro_siguiente_Click);
            // 
            // btn_ultimo_registro
            // 
            this.btn_ultimo_registro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_ultimo_registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_ultimo_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo_registro.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ultimo_registro.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ultimo_registro.Location = new System.Drawing.Point(406, 126);
            this.btn_ultimo_registro.Name = "btn_ultimo_registro";
            this.btn_ultimo_registro.Size = new System.Drawing.Size(42, 31);
            this.btn_ultimo_registro.TabIndex = 9;
            this.btn_ultimo_registro.Text = ">>";
            this.btn_ultimo_registro.UseVisualStyleBackColor = true;
            this.btn_ultimo_registro.Click += new System.EventHandler(this.btn_ultimo_registro_Click);
            // 
            // grp_datos_usuario
            // 
            this.grp_datos_usuario.Controls.Add(this.txt_edad_usuario);
            this.grp_datos_usuario.Controls.Add(this.lbl_linea_edad);
            this.grp_datos_usuario.Controls.Add(this.txt_apellido_usuario);
            this.grp_datos_usuario.Controls.Add(this.lbl_linea_apellido);
            this.grp_datos_usuario.Controls.Add(this.txt_nombre_usuario);
            this.grp_datos_usuario.Controls.Add(this.lbl_linea_nombre);
            this.grp_datos_usuario.Controls.Add(this.btn_guardar_datos);
            this.grp_datos_usuario.Controls.Add(this.lbl_edad_usuario);
            this.grp_datos_usuario.Controls.Add(this.lbl_apellido_usuario);
            this.grp_datos_usuario.Controls.Add(this.lbl_nombre_usuario);
            this.grp_datos_usuario.Location = new System.Drawing.Point(22, 116);
            this.grp_datos_usuario.Name = "grp_datos_usuario";
            this.grp_datos_usuario.Size = new System.Drawing.Size(497, 124);
            this.grp_datos_usuario.TabIndex = 10;
            this.grp_datos_usuario.TabStop = false;
            this.grp_datos_usuario.Text = "groupBox1";
            this.grp_datos_usuario.Visible = false;
            // 
            // txt_edad_usuario
            // 
            this.txt_edad_usuario.BackColor = System.Drawing.Color.Black;
            this.txt_edad_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_edad_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_edad_usuario.Location = new System.Drawing.Point(308, 24);
            this.txt_edad_usuario.Name = "txt_edad_usuario";
            this.txt_edad_usuario.Size = new System.Drawing.Size(100, 19);
            this.txt_edad_usuario.TabIndex = 7;
            // 
            // lbl_linea_edad
            // 
            this.lbl_linea_edad.AutoSize = true;
            this.lbl_linea_edad.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_linea_edad.Location = new System.Drawing.Point(305, 41);
            this.lbl_linea_edad.Name = "lbl_linea_edad";
            this.lbl_linea_edad.Size = new System.Drawing.Size(157, 13);
            this.lbl_linea_edad.TabIndex = 11;
            this.lbl_linea_edad.Text = "_________________________";
            // 
            // txt_apellido_usuario
            // 
            this.txt_apellido_usuario.BackColor = System.Drawing.Color.Black;
            this.txt_apellido_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_apellido_usuario.Location = new System.Drawing.Point(86, 68);
            this.txt_apellido_usuario.Name = "txt_apellido_usuario";
            this.txt_apellido_usuario.Size = new System.Drawing.Size(100, 19);
            this.txt_apellido_usuario.TabIndex = 5;
            // 
            // lbl_linea_apellido
            // 
            this.lbl_linea_apellido.AutoSize = true;
            this.lbl_linea_apellido.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_linea_apellido.Location = new System.Drawing.Point(83, 86);
            this.lbl_linea_apellido.Name = "lbl_linea_apellido";
            this.lbl_linea_apellido.Size = new System.Drawing.Size(157, 13);
            this.lbl_linea_apellido.TabIndex = 10;
            this.lbl_linea_apellido.Text = "_________________________";
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.BackColor = System.Drawing.Color.Black;
            this.txt_nombre_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(86, 24);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(100, 19);
            this.txt_nombre_usuario.TabIndex = 3;
            // 
            // lbl_linea_nombre
            // 
            this.lbl_linea_nombre.AutoSize = true;
            this.lbl_linea_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_linea_nombre.Location = new System.Drawing.Point(83, 41);
            this.lbl_linea_nombre.Name = "lbl_linea_nombre";
            this.lbl_linea_nombre.Size = new System.Drawing.Size(157, 13);
            this.lbl_linea_nombre.TabIndex = 9;
            this.lbl_linea_nombre.Text = "_________________________";
            // 
            // btn_guardar_datos
            // 
            this.btn_guardar_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_guardar_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_guardar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_datos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_datos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_guardar_datos.Location = new System.Drawing.Point(362, 73);
            this.btn_guardar_datos.Name = "btn_guardar_datos";
            this.btn_guardar_datos.Size = new System.Drawing.Size(100, 36);
            this.btn_guardar_datos.TabIndex = 8;
            this.btn_guardar_datos.Text = "Guardar";
            this.btn_guardar_datos.UseVisualStyleBackColor = true;
            this.btn_guardar_datos.Click += new System.EventHandler(this.btn_guardar_datos_Click);
            // 
            // lbl_edad_usuario
            // 
            this.lbl_edad_usuario.AutoSize = true;
            this.lbl_edad_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_edad_usuario.Location = new System.Drawing.Point(247, 29);
            this.lbl_edad_usuario.Name = "lbl_edad_usuario";
            this.lbl_edad_usuario.Size = new System.Drawing.Size(56, 21);
            this.lbl_edad_usuario.TabIndex = 6;
            this.lbl_edad_usuario.Text = "Edad:";
            // 
            // lbl_apellido_usuario
            // 
            this.lbl_apellido_usuario.AutoSize = true;
            this.lbl_apellido_usuario.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_apellido_usuario.Location = new System.Drawing.Point(5, 70);
            this.lbl_apellido_usuario.Name = "lbl_apellido_usuario";
            this.lbl_apellido_usuario.Size = new System.Drawing.Size(83, 21);
            this.lbl_apellido_usuario.TabIndex = 4;
            this.lbl_apellido_usuario.Text = "Apellido:";
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(5, 33);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(82, 21);
            this.lbl_nombre_usuario.TabIndex = 2;
            this.lbl_nombre_usuario.Text = "Nombre:";
            // 
            // grp_mostrar_datos
            // 
            this.grp_mostrar_datos.Controls.Add(this.dgv_mostrar_registros);
            this.grp_mostrar_datos.Controls.Add(this.btn_ultimo_registro);
            this.grp_mostrar_datos.Controls.Add(this.btn_primer_registro);
            this.grp_mostrar_datos.Controls.Add(this.btn_registro_siguiente);
            this.grp_mostrar_datos.Controls.Add(this.btn_registro_anterior);
            this.grp_mostrar_datos.Location = new System.Drawing.Point(22, 116);
            this.grp_mostrar_datos.Name = "grp_mostrar_datos";
            this.grp_mostrar_datos.Size = new System.Drawing.Size(511, 180);
            this.grp_mostrar_datos.TabIndex = 11;
            this.grp_mostrar_datos.TabStop = false;
            this.grp_mostrar_datos.Text = "groupBox1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // img_buscar_registro
            // 
            this.img_buscar_registro.Image = global::crud_conexion_BD.Properties.Resources.buscar;
            this.img_buscar_registro.Location = new System.Drawing.Point(580, 63);
            this.img_buscar_registro.Name = "img_buscar_registro";
            this.img_buscar_registro.Size = new System.Drawing.Size(30, 29);
            this.img_buscar_registro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_buscar_registro.TabIndex = 12;
            this.img_buscar_registro.TabStop = false;
            this.img_buscar_registro.Click += new System.EventHandler(this.img_buscar_registro_Click);
            // 
            // txt_buscar_registro
            // 
            this.txt_buscar_registro.BackColor = System.Drawing.Color.Black;
            this.txt_buscar_registro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar_registro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_registro.ForeColor = System.Drawing.Color.LightGray;
            this.txt_buscar_registro.Location = new System.Drawing.Point(459, 66);
            this.txt_buscar_registro.Name = "txt_buscar_registro";
            this.txt_buscar_registro.Size = new System.Drawing.Size(100, 19);
            this.txt_buscar_registro.TabIndex = 13;
            // 
            // lbl_buscar_registro
            // 
            this.lbl_buscar_registro.AutoSize = true;
            this.lbl_buscar_registro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_registro.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_buscar_registro.Location = new System.Drawing.Point(421, 72);
            this.lbl_buscar_registro.Name = "lbl_buscar_registro";
            this.lbl_buscar_registro.Size = new System.Drawing.Size(29, 20);
            this.lbl_buscar_registro.TabIndex = 14;
            this.lbl_buscar_registro.Text = "ID:";
            // 
            // lbl_linea_id
            // 
            this.lbl_linea_id.AutoSize = true;
            this.lbl_linea_id.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_linea_id.Location = new System.Drawing.Point(456, 84);
            this.lbl_linea_id.Name = "lbl_linea_id";
            this.lbl_linea_id.Size = new System.Drawing.Size(118, 13);
            this.lbl_linea_id.TabIndex = 15;
            this.lbl_linea_id.Text = "__________________-";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(680, 458);
            this.Controls.Add(this.txt_buscar_registro);
            this.Controls.Add(this.lbl_linea_id);
            this.Controls.Add(this.lbl_buscar_registro);
            this.Controls.Add(this.img_buscar_registro);
            this.Controls.Add(this.grp_mostrar_datos);
            this.Controls.Add(this.grp_datos_usuario);
            this.Controls.Add(this.img_crear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_eliminar);
            this.Controls.Add(this.img_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_registros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_crear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_editar)).EndInit();
            this.grp_datos_usuario.ResumeLayout(false);
            this.grp_datos_usuario.PerformLayout();
            this.grp_mostrar_datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_buscar_registro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_crear;
        private System.Windows.Forms.PictureBox img_editar;
        private System.Windows.Forms.PictureBox img_eliminar;
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
        private System.Windows.Forms.GroupBox grp_datos_usuario;
        private System.Windows.Forms.TextBox txt_edad_usuario;
        private System.Windows.Forms.Label lbl_edad_usuario;
        private System.Windows.Forms.TextBox txt_apellido_usuario;
        private System.Windows.Forms.Label lbl_apellido_usuario;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.Button btn_guardar_datos;
        private System.Windows.Forms.GroupBox grp_mostrar_datos;
        private System.Windows.Forms.Label lbl_linea_edad;
        private System.Windows.Forms.Label lbl_linea_apellido;
        private System.Windows.Forms.Label lbl_linea_nombre;
        private System.Windows.Forms.Button btn_minimizar_form;
        private System.Windows.Forms.Button btn_cerrar_formulario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox img_buscar_registro;
        private System.Windows.Forms.Label lbl_buscar_registro;
        private System.Windows.Forms.TextBox txt_buscar_registro;
        private System.Windows.Forms.Label lbl_linea_id;
    }
}

