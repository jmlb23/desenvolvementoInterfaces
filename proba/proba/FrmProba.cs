using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba
{
    public partial class FrmProba : Form
    {
        public FrmProba()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            //this.BtnSalir.BackColor = Color.Blue;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void btnColor_Click(object sender, EventArgs e) 
        {
            this.BackColor = Color.Red;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            new FrmEjerc().ShowDialog();
        }
    }

}
