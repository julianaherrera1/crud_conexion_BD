using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crud_conexion_BD
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        // Conexion con base de datos sql server
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-KQUVA2I\SQLEXPRESS;Initial Catalog=USUARIOS;Integrated Security=True");



        // Variables globales
        public DataTable dataTable;
        public int posicionActual = -1;


       

        private void btn_minimizar_form_Click(object sender, EventArgs e)
        {
            // Minimizar formulario
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_formulario_Click(object sender, EventArgs e)
        {
            // Cerrar formulario
            Application.Exit();
        }
        private void frm1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KQUVA2I\SQLEXPRESS;Initial Catalog=USUARIOS;Integrated Security=True";
            string query = "SELECT * FROM tbl_usuarios"; // Reemplaza "tbl_usuarios" con el nombre de tu tabla

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                    }
                }
            }

            MostrarRegistroActual();
        }


        /// <summary>
        /// CODIGO NAVEGACION 
        ///  PRIMERO REGISTRO / ANTERIOR Y SIGUIENTE / ULTIMO REGISTRO
        /// </summary>


        private void btn_primer_registro_Click(object sender, EventArgs e)
        {
            // BOTON PARA NAVEGAR AL PRIMER REGISTRO

            try
            {
                // Abrir conexion con base de datos
                conexion.Open();

                // Objeto para ejecutar la consulta SQL
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_usuarios ORDER BY ID ASC", conexion);

                // Crear un objeto para leer los resultado de la consulta 
                SqlDataReader lector = cmd.ExecuteReader();

                // Verificar si hay filas en el resultado
                if (lector.HasRows)
                {
                    // Leer la primera fila del resultado 
                    lector.Read();

                    // Limpiar el datagridview 
                    limpiar();

                    //Agregar los datos al datagrid
                    dgv_mostrar_registros.Rows.Add(lector["ID"], lector["Nombre"], lector["Apellido"], lector["Edad"]);
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error en la lectura del registro: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btn_ultimo_registro_Click(object sender, EventArgs e)
        {
            // BOTON PARA NAVEGAR AL ULTIMO REGISTRO

            try
            {
                // Abrir conexion con base de datos
                conexion.Open();

                // Objeto para ejecutar la consulta SQL
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_usuarios ORDER BY ID DESC", conexion);

                // Crear un objeto para leer los resultado de la consulta 
                SqlDataReader lector = cmd.ExecuteReader();

                // Verificar si hay filas en el resultado
                if (lector.HasRows)
                {
                    // Leer la primera fila del resultado 
                    lector.Read();

                    // Limpiar el datagridview 
                    limpiar();

                    //Agregar los datos al datagrid
                    dgv_mostrar_registros.Rows.Add(lector["ID"], lector["Nombre"], lector["Apellido"], lector["Edad"]);
                }
                lector.Close();
                posicionActual = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error en la lectura del registro: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btn_registro_anterior_Click(object sender, EventArgs e)
        {
            MostrarRegistroAnterior();
        }

        private void btn_registro_siguiente_Click(object sender, EventArgs e)
        {

            /*try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM tbl_usuarios", conexion);
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        if (lector.Read())
                        {
                            // Mover el lector al siguiente registro
                            for (int i = 0; i < posicionActual; i++)
                            {
                                lector.Read();
                            }

                            // Limpiar el DataGridView
                            dgv_mostrar_registros.Rows.Clear();

                            // Agregar los datos al DataGridView
                            dgv_mostrar_registros.Rows.Add(lector["ID"], lector["Nombre"], lector["Apellido"], lector["Edad"]);
                        }
                    }
                    else
                    {
                        dgv_mostrar_registros.Rows.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }*/
            

            posicionActual++;
            if (posicionActual >= dataTable.Rows.Count)
                posicionActual = 0;

            MostrarRegistroActual();




        }

        private void dgv_mostrar_registros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /// <summary>
        /// CRUD : CREAR, EDITAR, ELIMINAR Y CONSULTAR LOS REGISTROS
        /// </summary>


        // CREAR UN NUEVO REGISTRO
        private void img_crear_Click(object sender, EventArgs e)
        {
            // Baja la localizacion del group box que muestra los registros

            grp_datos_usuario.Visible = true;
            int desplazamientoVertical = 130; // Ajusta el valor del desplazamiento según tus necesidades
            grp_mostrar_datos.Location = new Point(grp_mostrar_datos.Location.X, grp_mostrar_datos.Location.Y + desplazamientoVertical);

        }

        private void btn_guardar_datos_Click(object sender, EventArgs e)
        {
            // Boton guarda el nuevo registro 

            grp_datos_usuario.Visible = false;
            int desplazamientoVertical = 120; // Ajusta el valor del desplazamiento según tus necesidades
            grp_mostrar_datos.Location = new Point(grp_mostrar_datos.Location.X, grp_mostrar_datos.Location.Y - desplazamientoVertical);

            // Asigar el valor de los textbox a una nueva variable
            string nombre = txt_nombre_usuario.Text;
            string apellido = txt_apellido_usuario.Text;
            string edad = txt_edad_usuario.Text;

            // Validar campos no esten vacios
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(edad))
            {
                MessageBox.Show(" TODOS LOS CAMPOS DEBEN ESTAR COMPLETOS");
                return;
            }

            // Validar que el campo edad sea un numero entero
            int edadInt;
            if (!int.TryParse(edad, out edadInt))
            {
                MessageBox.Show(" LA EDAD DEBE SER UN VALOR ENTERO");
                return;
            }

            // crear consulta sql
            string consulta = "INSERT INTO tbl_usuarios ( Nombre, Apellido, Edad) VALUES (@nombre, @apellido, @edad)";

            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    // Abrir conexion con bd
                    conexion.Open();

                    // Asignar los valores a los parametros del comando SQL
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@edad", edad);

                    // Ejecutar el comando SQL
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se inserto correctamente el registro
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show(" Registro creado exitosamente");
                        limpiar_textbox();
                    }
                    else
                    {
                        MessageBox.Show(" Error al crear el registro");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al crear el registro: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        // EDITAR UN REGISTRO
        private void img_editar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" RECUERDE DARLE ENTER PARA PODER HACER LA CORRECTA ACTUALIZACION");
            dgv_mostrar_registros.ReadOnly = false;
            dgv_mostrar_registros.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            int id = Convert.ToInt32(dgv_mostrar_registros.CurrentRow.Cells["id_usuario"].Value);
            string nombre = dgv_mostrar_registros.CurrentRow.Cells["nombre_usuario"].Value.ToString();
            string apellido = dgv_mostrar_registros.CurrentRow.Cells["apellido_usuario"].Value.ToString();
            string edad = dgv_mostrar_registros.CurrentRow.Cells["edad_usuario"].Value.ToString();


            // Consulta SQL
            string consulta = "UPDATE tbl_usuarios SET  Nombre=@nombre, Apellido=@apellido, Edad=@edad WHERE ID = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                try
                {
                    // Abrir conexion bd
                    conexion.Open();

                    //Asignar valores a los parametros del comando sql
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@edad", edad);
                    comando.Parameters.AddWithValue("@id", id);


                    // Ejecutar comando 
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se actualizo correctamente el registro
                    if (filasAfectadas > 0)
                    {

                        MessageBox.Show(" Registro actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show(" Error al actualizar el registro");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error al editar el archivo: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
        }

        // ELIMINAR UN REGISTRO
        private void img_eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_mostrar_registros.CurrentRow.Cells["id_usuario"].Value);
            string consulta = "DELETE FROM tbl_usuarios WHERE ID = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                // Asigna el valor del ID del registro a eliminar al parámetro del comando
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    // Abrir la conexión 
                    conexion.Open();

                    // Ejecuta el comando de eliminación
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verifica si se eliminó correctamente el registro
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro eliminado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para eliminar");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        // Cierra la conexión a la base de datos
                        conexion.Close();

                    }
                }
            }
        }

        // CONSULTAR DATOS
        private void img_buscar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_buscar_registro.Text);
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_usuarios WHERE ID=@id", conexion);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader lector = cmd.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Read();
                    limpiar();
                    limpiar_textbox();
                    dgv_mostrar_registros.Rows.Add(lector["ID"], lector["Nombre"], lector["Apellido"], lector["Edad"]);
                }
                else
                {
                    MessageBox.Show(" No hay ningun registro con este ID");
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el registro: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }



        /// <summary>
        /// METODOS:
        /// </summary>
        public void limpiar()
        {
            dgv_mostrar_registros.Rows.Clear();
        }

        public void limpiar_textbox()
        {
            txt_nombre_usuario.Text = "";
            txt_apellido_usuario.Text = "";
            txt_edad_usuario.Text = "";
            txt_buscar_registro.Text = "";
            txt_nombre_usuario.Focus();
        }
        public void MostrarRegistroActual()
        {
            if (posicionActual >= 0 && posicionActual < dataTable.Rows.Count)
            {
                DataRow row = dataTable.Rows[posicionActual];
                dgv_mostrar_registros.Rows.Clear();
                dgv_mostrar_registros.Rows.Add(row["ID"], row["Nombre"], row["Apellido"], row["Edad"]);
            }
            else
            {
                dgv_mostrar_registros.Rows.Clear();
            }
        }
        private void MostrarRegistroAnterior()
        {
            posicionActual--;
            if (posicionActual < 0)
                posicionActual = dataTable.Rows.Count - 1;

            MostrarRegistroActual();
        }


    }
}
