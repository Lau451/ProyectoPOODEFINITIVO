﻿namespace ProyectoPOO
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnventas = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(319, 85);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 20);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Location = new System.Drawing.Point(319, 156);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(21, 20);
            this.lblcargo.TabIndex = 4;
            this.lblcargo.Text = "...";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(319, 219);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(21, 20);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = "...";
            // 
            // btnventas
            // 
            this.btnventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.Location = new System.Drawing.Point(74, 333);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(197, 64);
            this.btnventas.TabIndex = 6;
            this.btnventas.Text = "VENTAS";
            this.btnventas.UseVisualStyleBackColor = true;
            // 
            // btncompras
            // 
            this.btncompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.Location = new System.Drawing.Point(323, 333);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(197, 64);
            this.btncompras.TabIndex = 7;
            this.btncompras.Text = "COMPRAS";
            this.btncompras.UseVisualStyleBackColor = true;
            // 
            // btnclientes
            // 
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.Location = new System.Drawing.Point(563, 333);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(197, 64);
            this.btnclientes.TabIndex = 8;
            this.btnclientes.Text = "CLIENTES";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.btncompras);
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Timer timer1;
    }
}