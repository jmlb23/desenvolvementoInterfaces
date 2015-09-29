using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;
namespace proba
{
    public partial class FrmEjerc : Form
    {
        public FrmEjerc()
        {
            InitializeComponent();
        }
        
        private void FrmEjerc_Load(object sender, EventArgs e)
        {
        
        }

        private void operacion(object sender, EventArgs e) {
            Button b = (Button)sender;
            switch(b.Text){
                case "+":
                    if (txtUn.Text.Equals("")  || txtDous.Text.Equals(""))
                    {
                        MessageBox.Show("METE VALORES");
                    }
                    else 
                    {
                        lblResult.Text = string.Format("{0}", (double.Parse(txtUn.Text) + double.Parse(txtDous.Text)));
                    }
                    break;
                case "-":
                    if (txtUn.Text.Equals("") || txtDous.Text.Equals(""))
                    {
                        MessageBox.Show("METE VALORES");
                    }
                    else
                    {
                        lblResult.Text = string.Format("{0}", (double.Parse(txtUn.Text) - double.Parse(txtDous.Text)));
                    }
                    break;
                case "*":
                    if (txtUn.Text.Equals("") || txtDous.Text.Equals(""))
                    {
                        MessageBox.Show("METE VALORES");
                    }
                    else
                    {
                        lblResult.Text = string.Format("{0}", (double.Parse(txtUn.Text) * double.Parse(txtDous.Text)));
                    }
                    break;
                case "/":
                    if (txtUn.Text.Equals("") || txtDous.Text.Equals(""))
                    {
                        MessageBox.Show("METE VALORES");
                    }
                    else
                    {
                        lblResult.Text = string.Format("{0}",(double.Parse(txtUn.Text) / double.Parse(txtDous.Text)));
                    }
                    break;
            }
        }
    }
}
