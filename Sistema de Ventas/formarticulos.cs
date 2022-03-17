using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class formarticulos : Form
    {
        public formarticulos()
        {
            InitializeComponent();
        }

        Funciones Funciones = new Funciones();
        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {
            FormCrearArticulo frm = new FormCrearArticulo();

            frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Funciones.BuscarArticulos(Dgvarticulos, txtBucar.Text);
        }

        private void formarticulos_Load(object sender, EventArgs e)
        {
            Funciones.BuscarArticulos(Dgvarticulos, txtBucar.Text);
        }

        private void Dgvarticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBucar_TextChanged(object sender, EventArgs e)
        {
            Funciones.BuscarArticulos(Dgvarticulos, txtBucar.Text);
        }

        private void formarticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        
        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
