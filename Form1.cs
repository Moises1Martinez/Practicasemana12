using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicasemana12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void testToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //instanciamo 
            frmTest fm = new frmTest();
            fm.MdiParent = this;
            fm.Show();
        }

        private void edifcioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEdificio fm = new FrmEdificio();
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
