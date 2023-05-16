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
                if(lector.HasRows)
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
            catch(Exception ex)
            {
                MessageBox.Show(" Error en la lectura del registro: " + ex.Message);
            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
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
            // Boton para navegar al registro anterior
            try
            {
                if(posicionActual > 0)
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
            catch(Exception ex)
            {
                MessageBox.Show(" Error al leer el registro: " + ex.Message);
            }
            finally
            {
                // Verificar si la conexion esta abierta, de ser asi cerrarla
                if(conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }

        private void btn_registro_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                btn_registro_siguiente.Enabled = true;
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
                    else
                    {
                        btn_registro_siguiente.Enabled = false;
                    }

                    lector.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Error al leer el registro: " + ex.Message);
            }
            finally
            {
                // Verificar si conexion esta abierta, de ser asi cerrarla
                if(conexion.State == ConnectionState.Open)
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

       
    }
}
