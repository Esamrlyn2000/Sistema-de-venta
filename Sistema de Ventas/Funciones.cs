using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public class Funciones
    {

        public ComboBox  cargarcategorias (ComboBox combo)
        {
            string consulta = "select descripcion from tblcategoria order by descripcion asc  ";
            SqlCommand  cmd = new SqlCommand (consulta, Conexion.ObtenerConeccion());
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        combo.Items.Add(reader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.ObtenerConeccion().Close();
            }

            return combo;   

        }

    }
}
