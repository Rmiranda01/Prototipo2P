
namespace CapaVista
{
    partial class Conciliacion
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
            this.Txtmovimiento = new System.Windows.Forms.TextBox();
            this.Txtfecha = new System.Windows.Forms.TextBox();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Conciliacion Bancaria";
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(554, 152);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(94, 33);
            this.Btneliminar.TabIndex = 44;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.Location = new System.Drawing.Point(554, 76);
            this.Btnmodificar.Name = "Btnmodificar";
            this.Btnmodificar.Size = new System.Drawing.Size(94, 39);
            this.Btnmodificar.TabIndex = 43;
            this.Btnmodificar.Text = "Modificar";
            this.Btnmodificar.UseVisualStyleBackColor = true;
            // 
            // Btnmostrar
            // 
            this.Btnmostrar.Location = new System.Drawing.Point(400, 152);
            this.Btnmostrar.Name = "Btnmostrar";
            this.Btnmostrar.Size = new System.Drawing.Size(94, 33);
            this.Btnmostrar.TabIndex = 42;
            this.Btnmostrar.Text = "Mostrar";
            this.Btnmostrar.UseVisualStyleBackColor = true;
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(400, 76);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(87, 39);
            this.Btnagregar.TabIndex = 41;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            // 
            // Dtg1
            // 
            this.Dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg1.Location = new System.Drawing.Point(170, 270);
            this.Dtg1.Name = "Dtg1";
            this.Dtg1.RowHeadersWidth = 51;
            this.Dtg1.RowTemplate.Height = 24;
            this.Dtg1.Size = new System.Drawing.Size(407, 150);
            this.Dtg1.TabIndex = 40;
            // 
            // Txtmovimiento
            // 
            this.Txtmovimiento.Location = new System.Drawing.Point(241, 168);
            this.Txtmovimiento.Name = "Txtmovimiento";
            this.Txtmovimiento.Size = new System.Drawing.Size(100, 22);
            this.Txtmovimiento.TabIndex = 38;
            // 
            // Txtfecha
            // 
            this.Txtfecha.Location = new System.Drawing.Point(241, 113);
            this.Txtfecha.Name = "Txtfecha";
            this.Txtfecha.Size = new System.Drawing.Size(100, 22);
            this.Txtfecha.TabIndex = 37;
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.Location = new System.Drawing.Point(241, 66);
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(100, 22);
            this.Txtcodigo.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Movimientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha de generacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Codigo de la conciliacion";
            // 
            // Conciliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btnmodificar);
            this.Controls.Add(this.Btnmostrar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.Dtg1);
            this.Controls.Add(this.Txtmovimiento);
            this.Controls.Add(this.Txtfecha);
            this.Controls.Add(this.Txtcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Conciliacion";
            this.Text = "Conciliacion";
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
        private System.Windows.Forms.TextBox Txtmovimiento;
        private System.Windows.Forms.TextBox Txtfecha;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}