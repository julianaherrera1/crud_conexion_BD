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
        public int posicionActual = 0;

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

        private void btn_primer_registro_Click(object sender, EventArgs e)
        {
            // Boton para navegar al primer registro
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
            // Boton para navegar al primer registro
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
            bool validar_ultimo_registro = false;
            // Boton para navegar al registro anterior
            try
            {
                if (posicionActual > 0)
                {
                    posicionActual--;

                    // Abrir conexion con bd
                    conexion.Open();

                    // Crear objeto para consulta SQL
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_usuarios ORDER BY ID ASC", conexion);

                    // Objeto para leer los resultados 
                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.HasRows)
                    {
                        validar_ultimo_registro = true;
                        btn_registro_anterior.Enabled = true;
                        // Mover el lector al registro anterior 
                        for (int i = 0; i <= posicionActual; i++)
                        {
                            lector.Read();
                        }

                        // limpiar datagrid
                        limpiar();

                        // Agregar datos a datagrid
                        dgv_mostrar_registros.Rows.Add(lector["ID"], lector["Nombre"], lector["Apellido"], lector["Edad"]);

                        // Mover el foco al registro anterior 
                        dgv_mostrar_registros.CurrentCell = dgv_mostrar_registros.Rows[posicionActual].Cells[0];

                    }

                    lector.Close();
                }
            }
            catch
            {
                if (validar_ultimo_registro == false)
                {
                    btn_registro_anterior.Enabled = false;
                }
            }
            finally
            {
                // Verificar si la conexion esta abierta, de ser asi cerrarla
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }

        private void btn_registro_siguiente_Click(object sender, EventArgs e)
        {
            bool validar_ultimo_registro = false;
            try
            {
                if (posicionActual >= 0)
                {
                    posicionActual++;

                    // Abrir conexion con bd
                    conexion.Open();

                    // Objeto para hacer consulta SQL
                    SqlCommand cmd = new SqlCommand(" SELECT * FROM tbl_usuarios ORDER BY ID ASC", conexion);
                    // Objeto para leer los reultados de la consulta
                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.HasRows)
                    {
                        validar_ultimo_registro = true;
                        btn_registro_siguiente.Enabled = true;
                        // Mover el lector al registro siguiente
                        for (int i = 0; i <= posicionActual; i++)
                        {
                            lector.Read();
                        }

                        // Limpiar datagrid
                        limpiar();

                        // Agregar datos al datagrid
                        dgv_mostrar_registros.Rows.Add(lector["ID"], lector["Nombre"], lector["Apellido"], lector["Edad"]);

                    }

                    lector.Close();
                }

            }
            catch
            {
                if (validar_ultimo_registro == false)
                {
                    btn_registro_siguiente.Enabled = false;
                }
            }
            finally
            {
                // Verificar si conexion esta abierta, de ser asi cerrarla
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }

        private void dgv_mostrar_registros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        // METODOS:
        public void limpiar()
        {
            dgv_mostrar_registros.Rows.Clear();
        }

        private void img_crear_Click(object sender, EventArgs e)
        {
            grp_datos_usuario.Visible = true;
            int desplazamientoVertical = 120; // Ajusta el valor del desplazamiento según tus necesidades
            grp_mostrar_datos.Location = new Point(grp_mostrar_datos.Location.X, grp_mostrar_datos.Location.Y + desplazamientoVertical);


        }

        private void btn_guardar_datos_Click(object sender, EventArgs e)
        {
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
                if(conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }




        }

        // METODOS: 
        public void limpiar_textbox()
        {
            txt_nombre_usuario.Text = "";
            txt_apellido_usuario.Text = "";
            txt_edad_usuario.Text = "";
            txt_nombre_usuario.Focus();
        }

        private void img_editar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" RECUERDE DARLE ENTER PARA PODER HACER LA CORRECTA ACTUALIZACION");
            dgv_mostrar_registros.ReadOnly = false;
            dgv_mostrar_registros.EditMode = DataGridViewEditMode.EditOnEnter;

            int  id = Convert.ToInt32(dgv_mostrar_registros.CurrentRow.Cells["id_usuario"].Value);
            string nombre = dgv_mostrar_registros.CurrentRow.Cells["nombre_usuario"].Value.ToString();
            string apellido = dgv_mostrar_registros.CurrentRow.Cells["apellido_usuario"].Value.ToString();
            string edad = dgv_mostrar_registros.CurrentRow.Cells["edad_usuario"].Value.ToString();

            
            // Consulta SQL
            string consulta = "UPDATE tbl_usuarios SET  Nombre=@nombre, Apellido=@apellido, Edad=@edad WHERE ID = @id";

            using(SqlCommand comando = new SqlCommand(consulta, conexion))
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
                    if(filasAfectadas > 0)
                    {

                        MessageBox.Show(" Registro actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show(" Error al actualizar el registro");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(" Error al editar el archivo: " + ex.Message);
                }
                finally
                {
                    if(conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
        }

        private void dgv_mostrar_registros_KeyDown(object sender, KeyEventArgs e)
        {
            
               
        }
    }
}
