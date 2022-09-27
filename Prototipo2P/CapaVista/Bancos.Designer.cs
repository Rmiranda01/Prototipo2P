
namespace CapaVista
{
    partial class Bancos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Txtdireccion = new System.Windows.Forms.TextBox();
            this.Txtcontacto = new System.Windows.Forms.TextBox();
            this.Dtg1 = new System.Windows.Forms.DataGridView();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btnmodificar = new System.Windows.Forms.Button();
            this.Btnmostrar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contacto";
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.Location = new System.Drawing.Point(229, 84);
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(100, 22);
            this.Txtcodigo.TabIndex = 4;
            this.Txtcodigo.Tag = "idBancos";
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(229, 131);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(100, 22);
            this.Txtnombre.TabIndex = 5;
            this.Txtnombre.Tag = "Nombre_Banco";
            // 
            // Txtdireccion
            // 
            this.Txtdireccion.Location = new System.Drawing.Point(229, 186);
            this.Txtdireccion.Name = "Txtdireccion";
            this.Txtdireccion.Size = new System.Drawing.Size(100, 22);
            this.Txtdireccion.TabIndex = 6;
            this.Txtdireccion.Tag = "Direccion";
            // 
            // Txtcontacto
            // 
            this.Txtcontacto.Location = new System.Drawing.Point(229, 240);
            this.Txtcontacto.Name = "Txtcontacto";
            this.Txtcontacto.Size = new System.Drawing.Size(100, 22);
            this.Txtcontacto.TabIndex = 7;
            this.Txtcontacto.Tag = "Contacto";
            // 
            // Dtg1
            // 
            this.Dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg1.Location = new System.Drawing.Point(158, 288);
            this.Dtg1.Name = "Dtg1";
            this.Dtg1.RowHeadersWidth = 51;
            this.Dtg1.RowTemplate.Height = 24;
            this.Dtg1.Size = new System.Drawing.Size(407, 150);
            this.Dtg1.TabIndex = 12;
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(542, 170);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(94, 33);
            this.Btneliminar.TabIndex = 16;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.Location = new System.Drawing.Point(542, 94);
            this.Btnmodificar.Name = "Btnmodificar";
            this.Btnmodificar.Size = new System.Drawing.Size(94, 39);
            this.Btnmodificar.TabIndex = 15;
            this.Btnmodificar.Text = "Modificar";
            this.Btnmodificar.UseVisualStyleBackColor = true;
            this.Btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // Btnmostrar
            // 
            this.Btnmostrar.Location = new System.Drawing.Point(388, 170);
            this.Btnmostrar.Name = "Btnmostrar";
            this.Btnmostrar.Size = new System.Drawing.Size(94, 33);
            this.Btnmostrar.TabIndex = 14;
            this.Btnmostrar.Text = "Mostrar";
            this.Btnmostrar.UseVisualStyleBackColor = true;
            this.Btnmostrar.Click += new System.EventHandler(this.Btnmostrar_Click);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(388, 94);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(87, 39);
            this.Btnagregar.TabIndex = 13;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Registro de los Bancos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btnmodificar);
            this.Controls.Add(this.Btnmostrar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.Dtg1);
            this.Controls.Add(this.Txtcontacto);
            this.Controls.Add(this.Txtdireccion);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.Txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bancos";
            this.Text = "Bancos";
            this.Load += new System.EventHandler(this.Bancos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.TextBox Txtdireccion;
        private System.Windows.Forms.TextBox Txtcontacto;
        private System.Windows.Forms.DataGridView Dtg1;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btnmodificar;
        private System.Windows.Forms.Button Btnmostrar;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Label label5;
    }
}