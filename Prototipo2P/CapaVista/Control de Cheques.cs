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
    public partial class Control_de_Cheques : Form
    {
        Controlador cn = new Controlador();
        string table = "control_cheques";

        public void llenar()
        {
            DataTable dt = cn.llenarTbl(table);
            Dtg1.DataSource = dt;
        }
        public Control_de_Cheques()
        {
            InitializeComponent();
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            if (Txtcodigo.Text == "" || Txtconcepto.Text == "" || Txtmonto.Text == "" || Txtcuentabene.Text == "" || Txtfecha.Text == "" || Txtbanco.Text == "" || Txtidbanco.Text == "" || Txtidcuentabe.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {

                TextBox[] textbox = { Txtcodigo, Txtconcepto, Txtmonto, Txtcuentabene, Txtfecha, Txtbanco, Txtidbanco, Txtidcuentabe };
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
            if (Txtcodigo.Text == "" || Txtconcepto.Text == "" || Txtmonto.Text == "" || Txtcuentabene.Text == "" || Txtfecha.Text == "" || Txtbanco.Text == "" || Txtidbanco.Text == "" || Txtidcuentabe.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");

            }
            else
            {
                TextBox[] textbox = { Txtcodigo, Txtconcepto, Txtmonto, Txtcuentabene, Txtfecha, Txtbanco, Txtidbanco, Txtidcuentabe };
                int valor1 = int.Parse(Txtcodigo.Text);
                string campo = "idControl_Cheques = ";
                cn.actualizar(textbox, table, campo, valor1);
                MessageBox.Show("Dato modificado");
                llenar();
            }
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
                string condicion = "idControl_Cheques = ";
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
