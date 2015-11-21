using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.Load += new EventHandler(load);
            this.btnAgregar.Click += new EventHandler(click);
            this.btnLista.Click += new EventHandler(clickLista);
            this.btnBorrar.Click += new EventHandler(borra);
            this.btnCombo.Click += new EventHandler(engadeCombo);
            this.btnComboLista.Click += new EventHandler(clickCombo);

        }

        public void load(object sender, EventArgs e) 
        {
           
            
         
        }

        public void click(object sender, EventArgs e) 
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("mete algo pavo");
            }
            else if (lstNomes.FindStringExact(txtNome.Text) == ListBox.NoMatches /* ou -1 xa que nomatches é unha constante*/)
            {
                lstNomes.Items.Add(txtNome.Text);
                txtNome.Text = "";
            }
            else 
            {
                MessageBox.Show("xa existe");
            }
        
        }
        public void clickCombo(object sender, EventArgs e)
        {


            if (cmbNome.SelectedIndex != -1)
            {
                lblLista.Text = cmbNome.SelectedIndex.ToString();
                lblLista2.Text = cmbNome.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("tes que ter selecionado algo");
            }

        }
        public void clickLista(object sender, EventArgs e) 
        {   
            
            MessageBox.Show("entra");
                if (lstNomes.SelectedIndex != -1)
                {
                    lblLista.Text = lstNomes.SelectedIndex.ToString();
                    lblLista2.Text = lstNomes.SelectedItem.ToString();
                }
                else
                {

                    MessageBox.Show("tes que ter selecionado algo", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                }
           
        }

        public void borra(object sender, EventArgs e) 
        {
            
            
            if (lstNomes.SelectedIndex != -1)
            {
                if( DialogResult.Yes == MessageBox.Show("estas seguro que queres borrar a "+lstNomes.SelectedItem.ToString()+"?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)) lstNomes.Items.RemoveAt(lstNomes.SelectedIndex);
            }
            else 
            {
                MessageBox.Show("tes que selecionar algo","ere",MessageBoxButtons.YesNoCancel);
               
            }
        }

        public void engadeCombo(object sender, EventArgs e) 
        {
            
            if(cmbNome.Text != "" && cmbNome.FindStringExact(cmbNome.Text) == -1) cmbNome.Items.Add(cmbNome.Text);
        }
    }
}
