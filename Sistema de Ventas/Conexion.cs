using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    internal class Conexion
    {

        
        public static SqlConnection ObtenerConeccion()
        {
            string consulta = (@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ventas;Data Source=COMPUTOS6\SQLEXPRESS");

            SqlConnection conectar = new SqlConnection(consulta);
            try
            {
             conectar.Open ();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return conectar;
        }
       


    }
}
