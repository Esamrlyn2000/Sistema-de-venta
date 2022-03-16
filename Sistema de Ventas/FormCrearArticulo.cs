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
    public partial class FormCrearArticulo : Form
    {
        public FormCrearArticulo()
        {
            InitializeComponent();
        }
        Funciones funcion = new Funciones();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmcategoria frm = new frmcategoria();
            cbCategoria.Items.Clear();
            frm.ShowDialog();
            funcion.cargarcategorias(cbCategoria);


        }

        private void FormCrearArticulo_Load(object sender, EventArgs e)
        {
            
            cbCategoria.Items.Clear();
           
            funcion.cargarcategorias(cbCategoria);

            if (cbCategoria.Items.Count > 0)
            {
                cbCategoria.SelectedIndex = 0;
            }
        }
    }
}
