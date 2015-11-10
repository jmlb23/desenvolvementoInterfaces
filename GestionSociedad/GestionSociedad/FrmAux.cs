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
    public partial class FrmAux : Form
    {
        DataSet dtsAux = new DataSet();
        OleDbDataAdapter adaCuotas; //non inicializamos o dataAdapter porque ocupa
        public FrmAux()
        {
            InitializeComponent();
            this.Load += (sender, even) => {
                
                adaCuotas = new OleDbDataAdapter("select * from Cuotas where AplicableA like 'S'",StructSoc.cnn); 
                adaCuotas.Fill(dtsAux, "Cuotas"); //enchemas o dataSet coa taboa que quremos
                cmbTipos.DataSource = dtsAux.Tables["Cuotas"]; //orixe
                cmbTipos.DisplayMember = "Descripcion"; //o que amosa
                cmbTipos.ValueMember = "TipoSocio"; //o que garda a maiores ligado o displayMember
                
            };


            //estos dous botons son o que fan que sexa un cadro de dialogo personalizado
            //cerra o form eten que salir cun valor dado xa que é feito por nos
            btnCamcelar.Click += (sender, even) => {
                //despois preguntamos no principal polo resultado
                //se da en cerrar tamen é como cancelar
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            //acepta e sal co valor
            btnAcep.Click += (sender, even) => {
                //é un array de chars ou esta implementado como un array de chars
                //string s = "";
                //System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][a-z|A-Z]");
                
                
                if (txtNif.Text.Equals("") || txtNombre.Text.Equals("") /*|| !r.IsMatch(s)*/)
                {
                    MessageBox.Show("Faltan cousas");
                    return;
                }
                this.DialogResult = DialogResult.OK;
            };
        }

      
    }
}
