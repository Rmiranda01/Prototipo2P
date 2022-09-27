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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bancos b = new Bancos();
            b.MdiParent = this;
            b.Show();
        }

        private void controlChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control_de_Cheques b = new Control_de_Cheques();
            b.MdiParent = this;
            b.Show();
        }
    }
}
