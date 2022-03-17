﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        Funciones funciones = new Funciones();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            funciones.cerrarVentana();
        }

        private void pbVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void pbInventario_Click(object sender, EventArgs e)
        {
            
        }

        private void pbInventario_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pbMantenimiento_Click(object sender, EventArgs e)
        {
            Mantenimiento frm = new Mantenimiento();

            frm.Show();
        }
    }
}
