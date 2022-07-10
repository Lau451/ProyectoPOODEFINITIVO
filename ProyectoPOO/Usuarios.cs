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
    public partial class Usuarios : Form
    {
        E_Users objent = new E_Users();
        N_Users objneg = new N_Users();
        public Usuarios()
        {
            InitializeComponent();
        }
        void mantenimiento(String accion)
        {
            objent.id_persona = txtpersona.Text;
            objent.id_tipo = txttipo.Text;                    
            objent.nombre = txtnombreu.Text;
            objent.usuario = txtusuariou.Text;
            objent.clave = txtcontraseña.Text;
            objent.correo = txtcorreo.Text;
            objent.dni = txtdni.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimiento_cliente(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txttipo.Text = "";
            txtpersona.Text = ""; 
            txtnombreu.Text = "";
            txtusuariou.Text = "";
            txtcontraseña.Text = "";
            txtcorreo.Text = "";
            txtdni.Text = "";
            txtbuscar.Text = "";
            dataGridView1.DataSource = objneg.N_listar_clientes();
        }

        private void Usuarios_Load(object sender, EventArgs e)

        {
            dataGridView1.DataSource = objneg.N_listar_clientes();
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtpersona.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtnombreu.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtpersona.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtnombreu.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Login.tipo=="A0001")
            {
                if (txtpersona.Text != "" && MessageBox.Show("¿Deseas eliminar a " + txtnombreu.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantenimiento("3");
                limpiar();
            }
            }else {btneliminar.Enabled = false;}
            

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                objent.nombre = txtbuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_clientes(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_listar_clientes();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int fila = dataGridView1.CurrentCell.RowIndex;

                txtpersona.Text = dataGridView1[1, fila].Value.ToString();
                txttipo.Text = dataGridView1[0, fila].Value.ToString();
                txtnombreu.Text = dataGridView1[2, fila].Value.ToString();
                txtusuariou.Text = dataGridView1[3, fila].Value.ToString();
                txtcontraseña.Text = dataGridView1[4, fila].Value.ToString();
                txtcorreo.Text = dataGridView1[5, fila].Value.ToString();
                txtdni.Text = dataGridView1[6, fila].Value.ToString();
            }
        }

        
    }
}