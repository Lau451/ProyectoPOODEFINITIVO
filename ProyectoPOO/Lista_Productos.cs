using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace ProyectoPOO
{
    public partial class Lista_Productos : Form
    {
        E_Productos objent = new E_Productos();
        N_Productos objneg = new N_Productos();
        public Lista_Productos()
        {
            InitializeComponent();
        }

        private void Lista_Productos_Load(object sender, EventArgs e)
        {
            dgvproductos.DataSource = objneg.N_listar_productos();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                objent.nombre = txtbuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_productos(objent);
                dgvproductos.DataSource = dt;
            }
            else
            {
                dgvproductos.DataSource = objneg.N_listar_productos();
            }
        }
    }
}
