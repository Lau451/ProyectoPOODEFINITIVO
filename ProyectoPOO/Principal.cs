﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            {
                //admin
                if (Login.tipo == "A0001")

                {

                    btnclientes.Enabled = true;
                    btnventas.Enabled = true;
                    btncompras.Enabled = true;

                    lblcargo.Text = "Administrador";
                }

                //Ventas
                else if (Login.tipo == "A0002")

                {
                    btnclientes.Enabled = false;
                    btnventas.Enabled = true;
                    btncompras.Enabled = false;

                    lblcargo.Text = "Ventas";
                }

                lblnombre.Text = Login.usuario_nombre;
                timer1.Start();

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Form form = new Usuarios();
            form.Show();
        }
    }
}