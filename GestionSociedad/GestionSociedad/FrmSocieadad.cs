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
        //os adapters coidado donde os creamos
        //dous adaptadores un para cada taboa sen inicializalos xa que ten que caragar o select
        OleDbDataAdapter adaSoc;
        OleDbDataAdapter adaBen;
        //xa creamos o dataset porque en principio esta valeiro
        //o dataset garda tamen relacions
        DataSet dtsSociedad = new DataSet();
        bool flag = true;
        bool flag2 = true;
        OleDbCommandBuilder cmbBuild; 
        public FrmSocieadad()
        {
            InitializeComponent();
            
            this.Load += (sender, e) =>
            {
                //creamos o adaptador para socios e cargar no combo os socios ordenado por apelidos

                //o adaptador carga a taboa e despois pilla o que queiramos se poñemos o select *
                //ollo se non precisamos todos os campos dunha taboa
                adaSoc = new OleDbDataAdapter("Select * from Socios order by Nombre",StructSoc.cnn);
                //cargamos o DataSet co Fill do adaptado
                adaSoc.Fill(dtsSociedad,"soc");
                //crear command builder porque hai crud
                //xa crea os inserts por nos
                cmbBuild = new OleDbCommandBuilder(adaSoc);
                //agregamos unha columna nova no dataset ollo que se facemos esta changa o dataset non serve para confirmar os cambios na bbdd
                //temos que dar tres parametro nome /ti`po /calculo para obter o valor
                //if(flag){
                //    //ollo con usar tablas con campos que non estan na bbdd xa que non nos vai deixar actualizar 
                //   dtsSociedad.Tables["soc"].Columns.Add("NombreCompleto",typeof(string),"Nombre+' '+Apellidos");
                //    flag = false;
                //}
                //orixen de datos
                cmbSocio.DataSource = dtsSociedad.Tables["soc"];
                //campo que se visualiza no combo
                cmbSocio.DisplayMember = "Nombre";
                //campo cuxo valor queremos que garde cando se elixe un socio
                cmbSocio.ValueMember = "NSocio";
                //facemos que no seleted non haxa ningun
                cmbSocio.SelectedIndex = -1;
                //SE ESTA ENLAZADO NON SE PODE modificar nada
                //cmbSocio.Sorted = true;

                //enlazamos as etiquetas cos datos dos socios


               

            };

            //cando cambia a selecion do combo
            cmbSocio.SelectionChangeCommitted += (sender, e) =>
            {
                //borrar do data set cada vez que entramos xa que o fill non é destructivo conserva os datos no dunha consulta a outra
                //temos que facelo sobre o dataset non sobre o control
                //non ten sentido borrar a colecion tables do dataset completa porque so queremos que borre a taboa concreta
                //dtsSociedad.Tables.Clear();
                //un control enlazado nunca se modifica perse hai que ir o dataset
                if (flag2 == true) { 
                    lblNsocio.DataBindings.Add("Text", dtsSociedad.Tables["soc"], "NSocio");
                    lblNif.DataBindings.Add("Text", dtsSociedad.Tables["soc"], "Nif");
                    flag2 = false;
                }
                //ollo que borrar as taboas como fixen antes funciona porque teño o valor do combo e traballo contra el
                //pero é unha moi mala practica
                adaBen = new OleDbDataAdapter("Select * from Beneficiarios where NSocio = "+cmbSocio.SelectedValue ,StructSoc.cnn);
                //borramos se hai algo no dataset
                if(dtsSociedad.Tables["Benef"] != null)dtsSociedad.Tables["Benef"].Rows.Clear();
                adaBen.Fill(dtsSociedad,"Benef");

                //orixe de datos
                lstBeneficiarios.DataSource = dtsSociedad.Tables["Benef"];
                //o que amosa
                lstBeneficiarios.DisplayMember = "Nombre";
            };

            btnVer.Click += (sender, e) => {
                OleDbCommand cmdContarSocios = new OleDbCommand("Select count(*) from Socios",StructSoc.cnn);
                OleDbCommand cmdContarBeneficiarios = new OleDbCommand("Select count(*) from Beneficiarios", StructSoc.cnn);
                //que cerre non implica que non teña que abrila
                using (StructSoc.cnn) {
                    StructSoc.cnn.Open();
                    lblNsoc.Text = cmdContarSocios.ExecuteScalar().ToString();
                    lblNben.Text = cmdContarBeneficiarios.ExecuteScalar().ToString();
                    
                }
            };



            mnuSalir.Click += (sender, e) => {
                this.Close();
            };

            mnuNovo.Click += (sender, ev) => {
                
                FrmAux novo = new FrmAux();
                DataRow dtr;
                novo.Text = "Novo Socio";

                //curioso como a condicion dun if pode funcionar como disparador
                if (novo.ShowDialog() == DialogResult.OK)
                {
                   
                        StructSoc.cnn.Open();
                        dtr = dtsSociedad.Tables["soc"].NewRow();
                        dtr["NSocio"] = obterUltimo(); //coidado cos tipos das bbdd e os controles
                        dtr["NIF"] = novo.txtNif.Text;
                        dtr["Nombre"] = novo.txtNombre.Text;
                        dtr["FechaAlta"] = novo.dtpData.Value;
                        dtr["Baja"] = novo.chkBaixa.Checked;
                        dtr["TipoSocio"] = novo.cmbTipos.SelectedValue; //porque é o que esta na fila selecionado o selected item danos toda a fila row

                        dtsSociedad.Tables["soc"].Rows.Add(dtr);
                        adaSoc.Update(dtsSociedad, "soc");
                        dtsSociedad.AcceptChanges();
                        StructSoc.cnn.Close();
                }
                else 
                {
                    return;
                }
            };
        }

        private short obterUltimo() {
            OleDbCommand cmm = new OleDbCommand("Select max(NSocio) from Socios",StructSoc.cnn); //vamos a bbdd e non o dataset para non crear inconsistencias
            object o;
             
                //StructSoc.cnn.Open();
                o = cmm.ExecuteScalar();
                StructSoc.cnn.Close();
            return o == DBNull.Value ? (short)1 : (short)(short.Parse(o.ToString()) + ((short)1));
        }
    }
}
