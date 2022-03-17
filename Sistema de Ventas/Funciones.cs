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
        public void insertarArticulos(Articulos articulo)
        {
            try
            {
                Conexion.ObtenerConeccion();
                SqlCommand cmd = new SqlCommand();
                string query = @"INSERT INTO tblarticulo(codigo, nombre, categoria, preciocompra, garantia, fechaentrada, fechavencimiento) values(@codigo, @nombre, @categoria, @preciocompra, @garantia, @fechaentrada, @fechavencimiento)";
                cmd.Parameters.Add(new SqlParameter("@codigo",articulo.codigo));
                cmd.Parameters.Add(new SqlParameter("@nombre", articulo.nombre));
                cmd.Parameters.Add(new SqlParameter("@categoria", articulo.categoria));
                cmd.Parameters.Add(new SqlParameter("@preciocompra", articulo.precioCompra));
                cmd.Parameters.Add(new SqlParameter("@garantia", articulo.garantia));
                cmd.Parameters.Add(new SqlParameter("@fechaentrada", articulo.fechaEntrada));
                cmd.Parameters.Add(new SqlParameter("@fechavencimiento", articulo.fechaVencimiento));
                cmd.Connection = Conexion.ObtenerConeccion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Mensaje de notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.ObtenerConeccion().Close();
            }
        }

        public void BuscarArticulos(DataGridView tabla,string busqueda)
        {
            try
            {
                Conexion.ObtenerConeccion();
                SqlCommand cmd = new SqlCommand();
                string query = "select * from tblarticulo where codigo like '%'+@codigo+'%' or nombre like '%'+@nombre+'%' or categoria like '%'+@categoria+'%'  ";
                cmd.Parameters.Add(new SqlParameter("@codigo", busqueda));
                cmd.Parameters.Add(new SqlParameter("@nombre", busqueda));
                cmd.Parameters.Add(new SqlParameter("@categoria", busqueda));
                cmd.Connection = Conexion.ObtenerConeccion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);    
                tabla.DataSource= dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Mensaje de notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.ObtenerConeccion().Close();
            }
        }


        public void insertar(string codigo,string des)
        {
            

            try
            {
                Conexion.ObtenerConeccion();
                SqlCommand cmd = new SqlCommand();
                string query = @"INSERT INTO tblcategoria (codigo,descripcion) VALUES (@codigo,@descripcion) ";
                cmd.Parameters.Add(new SqlParameter("@codigo", codigo));
                cmd.Parameters.Add(new SqlParameter("@descripcion", des));
                cmd.Connection = Conexion.ObtenerConeccion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Mensaje de notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexion.ObtenerConeccion().Close();
            }
        }

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
