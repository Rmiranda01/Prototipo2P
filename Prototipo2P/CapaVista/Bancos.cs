using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{

    public partial class Bancos : Form
    {
        Controlador cn = new Controlador();
        string table="bancos";

        public void llenar()
        {
            DataTable dt = cn.llenarTbl(table);
            Dtg1.DataSource = dt;
        }
        public Bancos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            if (Txtcodigo.Text == "" || Txtnombre.Text == "" || Txtdireccion.Text == "" || Txtcontacto.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {

                TextBox[] textbox = { Txtcodigo, Txtnombre, Txtdireccion, Txtcontacto};
                cn.ingresar(textbox, table);
                string message = "Registro Guardado";
                MessageBox.Show(message);
                llenar();
            }
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            llenar();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            if (Txtcodigo.Text == "" || Txtnombre.Text == "" || Txtdireccion.Text == "" || Txtcontacto.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");

            }
            else
            {
                TextBox[] textbox = { Txtcodigo, Txtnombre, Txtdireccion, Txtcontacto };
                int valor1 = int.Parse(Txtcodigo.Text);
                string campo = "idBancos = ";
                cn.actualizar(textbox, table, campo, valor1);
                MessageBox.Show("Dato modificado");
                llenar();
            }
        }

        private void Bancos_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(Txtcodigo.Text);
                string condicion = "idBancos = ";
                cn.eliminar(table, condicion, campo);
                llenar();
                MessageBox.Show("Registro Eliminado");

            }
            else
            {
                llenar();

            }
        }
    }
}
