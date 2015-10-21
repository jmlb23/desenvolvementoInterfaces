using System;
using System.Linq;
using System.Windows.Forms;

namespace Areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.rbtCadrado.CheckedChanged += new EventHandler(rbtCambio);
            this.rbtRectangulo.CheckedChanged += new EventHandler(rbtCambio);
            this.rbtCirculo.CheckedChanged += new EventHandler(rbtCambio);
            this.rbtTriangulo.CheckedChanged += new EventHandler(rbtCambio);
            this.rbtCadrado.Checked = true;
            this.txtun.KeyPress += new KeyPressEventHandler(valida);
            this.txtdous.KeyPress += new KeyPressEventHandler(valida);
            this.txtTres.KeyPress += new KeyPressEventHandler(valida);
            this.btnCalcula.Click += (object sender, EventArgs e) => {
                if (rbtCadrado.Checked)
                {
                    
                        lblResultado.Text = string.Format("{0:0.00}", Math.Pow(float.Parse(txtun.Text), 2));
                    
                }
                else if (rbtRectangulo.Checked)
                {
                    
                        lblResultado.Text = string.Format("{0:0.00}", (float.Parse(txtun.Text) * float.Parse(txtTres.Text)));
                   
                }
                else if (rbtCirculo.Checked)
                {
                   
                        lblResultado.Text = string.Format("{0:0.00}", (Math.PI * Math.Pow(float.Parse(txtdous.Text),2)));
                  
                }
                else if (rbtTriangulo.Checked)
                {
                   
                        lblResultado.Text = string.Format("{0:0.00}",(float.Parse(txtun.Text) * float.Parse(txtTres.Text))/2);
                    
                }
            };
            
        }

        private void valida(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='.')
            {
                e.KeyChar = ',';
            }

            if (!"123456789,\b".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (((TextBox)sender).Text.Equals("") && e.KeyChar == ',')
                {
                    e.Handled = true;

                }
                else if(((TextBox)sender).Text.Contains(',') && e.KeyChar == ',')
                {
                    e.Handled = true;
                }
            }
            
        }
        private void rbtCambio(object o,EventArgs e) {
            switch (((RadioButton)o).Text) {
                case "Cadrado":
                    lblun.Visible = true;
                    txtun.Visible = true;
                    lbldous.Visible = false;
                    txtdous.Visible = false;
                    lbltres.Visible = false;
                    txtTres.Visible = false;
                    break;
                case "Rectangulo":
                    lblun.Visible = true;
                    txtun.Visible = true;
                    lbldous.Visible = false;
                    txtdous.Visible = false;
                    lbltres.Visible = true;
                    txtTres.Visible = true;

                    break;
                case "Circulo":
                    lblun.Visible = false;
                    txtun.Visible = false;
                    lbldous.Visible = true;
                    txtdous.Visible = true;
                    lbltres.Visible = false;
                    txtTres.Visible = false;


                    break;
                case "Triangulo":
                    lblun.Visible = true;
                    txtun.Visible = true;
                    lbldous.Visible = false;
                    txtdous.Visible = false;
                    lbltres.Visible = true;
                    txtTres.Visible = true;


                    break;
            }
        }
    }
}
