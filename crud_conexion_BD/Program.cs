using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_conexion_BD
{
    /// <summary>
    /// Creada por: Juliana Herrera
    /// Fecha: 15/05/2023
    /// Aplicacion que se conecta con un motor de base de datos (sql server)
    /// directamente de una tabla y permite:
    /// 1. Crear / Eliminar / Actualizar / Consultar datos.
    /// 2. Navegacion: Primer registro / Siguiente / anterior / Ultimo registro 
    /// 
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm1());
        }
    }
}
