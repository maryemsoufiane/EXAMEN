using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN
{
    public partial class Exemen : Form
    {
        public Exemen()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            qcm qcm = new qcm();
            qcm.ShowDialog();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            quistion_vrais_faux   qm =new quistion_vrais_faux();
            qm.ShowDialog();
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            quistiondirect qd =new quistiondirect();
            qd.ShowDialog();
        }
    }
}
