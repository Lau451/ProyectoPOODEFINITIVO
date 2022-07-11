namespace ProyectoPOO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btnlista = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Location = new System.Drawing.Point(377, 81);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.BackColor = System.Drawing.Color.Transparent;
            this.lblcargo.Location = new System.Drawing.Point(377, 128);
            this.lblcargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(16, 13);
            this.lblcargo.TabIndex = 4;
            this.lblcargo.Text = "...";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Location = new System.Drawing.Point(377, 179);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(16, 13);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = "...";
            // 
            // btnproductos
            // 
            this.btnproductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnproductos.BackgroundImage")));
            this.btnproductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnproductos.Location = new System.Drawing.Point(61, 232);
            this.btnproductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(131, 42);
            this.btnproductos.TabIndex = 6;
            this.btnproductos.Text = "PRODUCTOS";
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btnlista
            // 
            this.btnlista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlista.BackgroundImage")));
            this.btnlista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlista.Location = new System.Drawing.Point(206, 232);
            this.btnlista.Margin = new System.Windows.Forms.Padding(2);
            this.btnlista.Name = "btnlista";
            this.btnlista.Size = new System.Drawing.Size(215, 42);
            this.btnlista.TabIndex = 7;
            this.btnlista.Text = "LISTA DE PRODUCTOS";
            this.btnlista.UseVisualStyleBackColor = true;
            this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclientes.BackgroundImage")));
            this.btnclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclientes.Location = new System.Drawing.Point(445, 232);
            this.btnclientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(105, 42);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 331);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.btnlista);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnlista;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Timer timer1;
    }
}