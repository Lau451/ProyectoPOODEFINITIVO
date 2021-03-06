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
    public partial class Registro : Form
    {
        E_Users objent = new E_Users();
        N_Users objneg = new N_Users();
        ValidarTxt validarTxt = new ValidarTxt();
        public Registro()
        {
            InitializeComponent();
        }
        void mantenimiento(String accion)
        {
            objent.id_persona = txtpersona.Text;
            objent.id_tipo = txttipo.Text;
            objent.nombre = txtnombre.Text;
            objent.usuario = txtusuario.Text;
            objent.clave = txtpass.Text;
            objent.correo = txtcorreo.Text;
            objent.dni = txtdni.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimiento_cliente(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txttipo.Text = "";
            txtnombre.Text = "";
            txtusuario.Text = "";
            txtpass.Text = "";
            txtcorreo.Text = "";
            txtdni.Text = "";
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtnombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                    this.Close();

                }
            }
        }
        ErrorProvider errorP = new ErrorProvider();
        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.soloNumeros(e);
            if (!valida)
            {
                errorP.SetError(txtdni, "Solo números");
                
            }else
                    errorP.Clear();
        }

        private void txttipo_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.TextVacios(txttipo))
            {
                errorP.SetError(txttipo, "El campo está vacio");
            } else 
                errorP.Clear();
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.TextVacios(txtnombre))
            {
                errorP.SetError(txtnombre, "El campo está vacio");
            }
            else
                errorP.Clear();
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.TextVacios(txtusuario))
            {
                errorP.SetError(txtusuario, "El campo está vacio");
            }
            else
                errorP.Clear();
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.TextVacios(txtpass))
            {
                errorP.SetError(txtpass, "El campo está vacio");
            }
            else
                errorP.Clear();
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.TextVacios(txtcorreo))
            {
                errorP.SetError(txtcorreo, "El campo está vacio");
            }
            else
                errorP.Clear();
            if (!ValidarTxt.ValidarEmail(txtcorreo.Text))
            {
                errorP.SetError(txtcorreo, "Correo no válido");
            }
            else
                errorP.Clear();
        }

        private void txtdni_Leave(object sender, EventArgs e)
        {
            if (ValidarTxt.TextVacios(txtdni))
            {
                errorP.SetError(txtdni, "El campo está vacio");
            }
            else
                errorP.Clear();
        }
    }
}
