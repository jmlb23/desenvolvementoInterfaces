using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GestionSociedad
{
    public partial class FrmSocieadad : Form
    {
        public FrmSocieadad()
        {
            InitializeComponent();
            btnVer.Click += (sender, e) => {
                OleDbCommand cmdContarSocios = new OleDbCommand("Select count(*) from Socios",ClassSoc.cnn);
                OleDbCommand cmdContarBeneficiarios = new OleDbCommand("Select count(*) from Beneficiarios", ClassSoc.cnn);
                //que cerre non implica que non teña que abrila
                using (ClassSoc.cnn) {
                    ClassSoc.cnn.Open();
                    lblNsoc.Text = cmdContarSocios.ExecuteScalar().ToString();
                    lblNben.Text = cmdContarBeneficiarios.ExecuteScalar().ToString();
                }
            };
        }
    }
}
