using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Dominio; 

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulos> listArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            pbArticulo.Load(dgvArticulos.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar Agregar = new frmAgregar();
            Agregar.ShowDialog();
            cargarArticulos();
        }

        public void cargarArticulos()
        {
            ArticuloNegocio negocioArticulos = new ArticuloNegocio();

            try
            {
                listArticulos = negocioArticulos.listar();

                dgvArticulos.DataSource = listArticulos;

                dgvArticulos.Columns["imagenURL"].Visible = false;

                dgvArticulos.Columns["ID"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
      
}
