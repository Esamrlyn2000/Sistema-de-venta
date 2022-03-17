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
            if (MessageBox.Show("Deseas Salir ", "Notificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
            {


            }
        }
    }
}
