using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datoslogin dl= new Datoslogin();
            prueba.Text = "Id = " + dl.id.ToString() + "\n";
            prueba.Text += "nombre = " + dl.nombre.ToString() + "\n";
            prueba.Text += "Contraseña = " + dl.contrasena.ToString() + "\n";
            prueba.Text += "Rol = " + dl.rol.ToString() + "\n";
            prueba.Text += "estado = " + dl.estado.ToString() + "\n";
            prueba.Visible = true;
        }
    }
}
