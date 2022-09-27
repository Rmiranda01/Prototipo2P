
namespace CapaVista
{
    partial class Control_de_Cheques
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
            this.label5 = new System.Windows.Forms.Label();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btnmodificar = new System.Windows.Forms.Button();
            this.Btnmostrar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Dtg1 = new System.Windows.Forms.DataGridView();
            this.Txtcuentabene = new System.Windows.Forms.TextBox();
            this.Txtmonto = new System.Windows.Forms.TextBox();
            this.Txtconcepto = new System.Windows.Forms.TextBox();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtbanco = new System.Windows.Forms.TextBox();
            this.Txtfecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txtidbanco = new System.Windows.Forms.TextBox();
            this.Txtidcuentabe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Registro de los Movimientos";
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(582, 162);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(94, 33);
            this.Btneliminar.TabIndex = 58;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.Location = new System.Drawing.Point(582, 86);
            this.Btnmodificar.Name = "Btnmodificar";
            this.Btnmodificar.Size = new System.Drawing.Size(94, 39);
            this.Btnmodificar.TabIndex = 57;
            this.Btnmodificar.Text = "Modificar";
            this.Btnmodificar.UseVisualStyleBackColor = true;
            this.Btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // Btnmostrar
            // 
            this.Btnmostrar.Location = new System.Drawing.Point(428, 162);
            this.Btnmostrar.Name = "Btnmostrar";
            this.Btnmostrar.Size = new System.Drawing.Size(94, 33);
            this.Btnmostrar.TabIndex = 56;
            this.Btnmostrar.Text = "Mostrar";
            this.Btnmostrar.UseVisualStyleBackColor = true;
            this.Btnmostrar.Click += new System.EventHandler(this.Btnmostrar_Click);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(428, 86);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(87, 39);
            this.Btnagregar.TabIndex = 55;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Dtg1
            // 
            this.Dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg1.Location = new System.Drawing.Point(399, 242);
            this.Dtg1.Name = "Dtg1";
            this.Dtg1.RowHeadersWidth = 51;
            this.Dtg1.RowTemplate.Height = 24;
            this.Dtg1.Size = new System.Drawing.Size(492, 150);
            this.Dtg1.TabIndex = 54;
            // 
            // Txtcuentabene
            // 
            this.Txtcuentabene.Location = new System.Drawing.Point(196, 242);
            this.Txtcuentabene.Name = "Txtcuentabene";
            this.Txtcuentabene.Size = new System.Drawing.Size(100, 22);
            this.Txtcuentabene.TabIndex = 53;
            this.Txtcuentabene.Tag = "Cuenta_Beneficiario";
            // 
            // Txtmonto
            // 
            this.Txtmonto.Location = new System.Drawing.Point(196, 188);
            this.Txtmonto.Name = "Txtmonto";
            this.Txtmonto.Size = new System.Drawing.Size(100, 22);
            this.Txtmonto.TabIndex = 52;
            this.Txtmonto.Tag = "Monto";
            // 
            // Txtconcepto
            // 
            this.Txtconcepto.Location = new System.Drawing.Point(196, 133);
            this.Txtconcepto.Name = "Txtconcepto";
            this.Txtconcepto.Size = new System.Drawing.Size(100, 22);
            this.Txtconcepto.TabIndex = 51;
            this.Txtconcepto.Tag = "Concepto";
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.Location = new System.Drawing.Point(196, 86);
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(100, 22);
            this.Txtcodigo.TabIndex = 50;
            this.Txtcodigo.Tag = "idControl_Cheques";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Cuenta  Beneficiario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Concepto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Codigo del Cheque";
            // 
            // Txtbanco
            // 
            this.Txtbanco.Location = new System.Drawing.Point(196, 343);
            this.Txtbanco.Name = "Txtbanco";
            this.Txtbanco.Size = new System.Drawing.Size(100, 22);
            this.Txtbanco.TabIndex = 63;
            this.Txtbanco.Tag = "Banco";
            // 
            // Txtfecha
            // 
            this.Txtfecha.Location = new System.Drawing.Point(196, 289);
            this.Txtfecha.Name = "Txtfecha";
            this.Txtfecha.Size = new System.Drawing.Size(100, 22);
            this.Txtfecha.TabIndex = 62;
            this.Txtfecha.Tag = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "Nombre Banco";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fecha del Movimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Id del Banco";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "id Cuenta del Benef";
            // 
            // Txtidbanco
            // 
            this.Txtidbanco.Location = new System.Drawing.Point(196, 389);
            this.Txtidbanco.Name = "Txtidbanco";
            this.Txtidbanco.Size = new System.Drawing.Size(100, 22);
            this.Txtidbanco.TabIndex = 66;
            this.Txtidbanco.Tag = "Bancos_idBancos";
            // 
            // Txtidcuentabe
            // 
            this.Txtidcuentabe.Location = new System.Drawing.Point(196, 429);
            this.Txtidcuentabe.Name = "Txtidcuentabe";
            this.Txtidcuentabe.Size = new System.Drawing.Size(100, 22);
            this.Txtidcuentabe.TabIndex = 67;
            this.Txtidcuentabe.Tag = "Cuentas_Clientes_idCuentas";
            // 
            // Control_de_Cheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(929, 528);
            this.Controls.Add(this.Txtidcuentabe);
            this.Controls.Add(this.Txtidbanco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txtbanco);
            this.Controls.Add(this.Txtfecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btnmodificar);
            this.Controls.Add(this.Btnmostrar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.Dtg1);
            this.Controls.Add(this.Txtcuentabene);
            this.Controls.Add(this.Txtmonto);
            this.Controls.Add(this.Txtconcepto);
            this.Controls.Add(this.Txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Control_de_Cheques";
            this.Text = "Control_de_Cheques";
            ((System.ComponentModel.ISupportInitialize)(this.Dtg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btnmodificar;
        private System.Windows.Forms.Button Btnmostrar;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.DataGridView Dtg1;
        private System.Windows.Forms.TextBox Txtcuentabene;
        private System.Windows.Forms.TextBox Txtmonto;
        private System.Windows.Forms.TextBox Txtconcepto;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtbanco;
        private System.Windows.Forms.TextBox Txtfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txtidbanco;
        private System.Windows.Forms.TextBox Txtidcuentabe;
    }
}