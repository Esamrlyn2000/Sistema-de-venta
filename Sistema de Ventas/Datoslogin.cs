using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas
{
    public class Datoslogin
    {

        //public string nombre { get; set; }
        //public string contrasena { get; set; }
        //public string estado { get; set; }
        //public string rol { get; set; }
        //public int id { get; set; }


        public static string Nombre;
        public string nombre
        {
            get { return Nombre; }  
            set { Nombre = value; } 
        }

        public static string Contrasena;
        public string contrasena
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }

        public static string Estado;
        public string estado
        {
            get { return Estado; }
            set { Estado = value; }
        }
        public static string Rol;
        public string rol
        {
            get { return Rol; }
            set { Rol = value; }
        }

        public static int Id;
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }


    }
}
