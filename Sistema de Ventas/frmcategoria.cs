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
    public partial class frmcategoria : Form
    {
        public frmcategoria()
        {
            InitializeComponent();
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
           Categorias categorias = new Categorias();
            categorias.codigo = txtCodigo.Text;
            categorias.descricion = txtDescripcion.Text;

        }
    }
}
