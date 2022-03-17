using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class Frmloging : Form
    {
        public Frmloging()
        {
            InitializeComponent();
        }

        public bool existe = false;
        public void Verificar(string user, string pass)
        {
            Datoslogin dl = new Datoslogin();

            MenuPrincipal frm = new MenuPrincipal();
            
            SqlCommand cmd = new SqlCommand();
            SqlDataReader lector;
            string query = "select * from tblusuarios where nombre = @usuario";
            cmd.Parameters.Add(new SqlParameter("@usuario", user));

            cmd.Connection = Conexion.ObtenerConeccion();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                lector = cmd.ExecuteReader();
                
                if(lector.HasRows)
                {
                    while(lector.Read())
                    {
                        //if(txtUsuario.Text.Trim() == lector.GetString(1)&& txtPass.Text== lector.GetString(2))
                        if (txtUsuario.Text.Trim() == lector["nombre"].ToString() && txtPass.Text == lector["contrasena"].ToString())
                        {
                            dl.id = Convert.ToInt32(lector["id"].ToString());
                            dl.nombre = lector["nombre"].ToString();
                            dl.rol = lector["rol"].ToString();
                            dl.contrasena = lector["contrasena"].ToString();
                            dl.estado = lector["estado"].ToString();

                            

                            frm.Show();
                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña incorrecta","Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    lector.Close();
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
            


        }


        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Verificar(txtUsuario.Text,txtPass.Text);

        }
    }
}
