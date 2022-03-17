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
            cargar();


        }

        public void cargar()
        {

            cbCategoria.Items.Clear();

            funcion.cargarcategorias(cbCategoria);

            if (cbCategoria.Items.Count > 0)
            {
                cbCategoria.SelectedIndex = 0;
            }
        }

        private void FormCrearArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void Btnagreagar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Focus();
                MessageBox.Show("No Puedes Dejar este campo vacio");
            }
            else
            {
                Articulos articulo = new Articulos();
                articulo.codigo = txtCodigo.Text.Trim();
                articulo.nombre = txtNombre.Text.Trim();
                articulo.categoria = cbCategoria.Text.Trim();
                articulo.precioCompra = float.Parse(txtPrecioCompra.Text.Trim());
                articulo.garantia = txtGarantia.Text.Trim();
                articulo.fechaEntrada = fechaentrada.Text.Trim();
                articulo.fechaVencimiento = fechavencimiento.Text.Trim();

                funcion.insertarArticulos(articulo);
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
