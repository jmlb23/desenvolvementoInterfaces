using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnList.Click += new EventHandler(func);
        }

        public void func(object sender, EventArgs e) 
        {
           lblNumero.Text = lstBox.SelectedIndex.ToString();
           lblSelecion.Text = lstBox.SelectedItem.ToString();
        }
    }
}
