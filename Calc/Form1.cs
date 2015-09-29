using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //handlers para os botons de numeros
            this.btnUn.Click += new System.EventHandler(Numeros);
            this.btnDous.Click += new System.EventHandler(Numeros);
            this.btnTres.Click += new System.EventHandler(Numeros);
            this.btnCatro.Click += new System.EventHandler(Numeros);
            this.btnCinco.Click += new System.EventHandler(Numeros);
            this.btnSeis.Click += new System.EventHandler(Numeros);
            this.btnSete.Click += new System.EventHandler(Numeros);
            this.btnOito.Click += new System.EventHandler(Numeros);
            this.btnNove.Click += new System.EventHandler(Numeros);

            //handlers para os signos
            this.btnMais.Click += new System.EventHandler(Suma);
            this.txtOperacion.Validating += new System.ComponentModel.CancelEventHandler(Valida);
        }
        //funcion asociada o delgate Click 
        public void Numeros(object o, EventArgs e)
        {
            Button b = (Button)o;
            txtOperacion.Text += b.Text;
        }

        public void Suma(object o, EventArgs e)
        {
            
        }

        public void Valida(object o, CancelEventArgs e)
        {
            double resultado = 0.0;
            //parametro out conserva o valor despois do retorno do ambito da funcion
            if (!double.TryParse(this.txtOperacion.Text, out resultado))
            {
                MessageBox.Show("so valores numericos validos");
            }
        }

    }
}
