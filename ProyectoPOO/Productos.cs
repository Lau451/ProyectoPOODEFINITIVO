using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace ProyectoPOO
{
    public partial class Productos : Form
    {
        E_Productos objent = new E_Productos();
        N_Productos objneg = new N_Productos();
        public Productos()
        {
            InitializeComponent();
        }
        void mantenimiento(String accion)
        {
            objent.id = txtid.Text;
            objent.nombre = txtnombre.Text;
            objent.descripcion = txtdescripcion.Text;
            objent.marca = txtmarca.Text;
            objent.precio = txtprecio.Text;
            objent.stock = txtstock.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimiento_productos(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtmarca.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            dataGridView1.DataSource = objneg.N_listar_productos();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_productos();
        }

        private void txtlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            mantenimiento("1");
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mantenimiento("3");
            limpiar();
        }

        private void txteditar_Click(object sender, EventArgs e)
        {
            mantenimiento("2");
            limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int fila = dataGridView1.CurrentCell.RowIndex;
                txtid.Text = dataGridView1[0, fila].Value.ToString();
                txtnombre.Text = dataGridView1[1, fila].Value.ToString();
                txtdescripcion.Text = dataGridView1[2, fila].Value.ToString();
                txtmarca.Text = dataGridView1[3, fila].Value.ToString();
                txtprecio.Text = dataGridView1[4, fila].Value.ToString();
                txtstock.Text = dataGridView1[5, fila].Value.ToString();
            }
        }
    }
}
