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
        bool flag2 = true;
        OleDbCommandBuilder cmbBuild;
        OleDbCommandBuilder cmbBuildBenef;
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
                lblCuouta.Text = "";
                //borrar do data set cada vez que entramos xa que o fill non é destructivo conserva os datos no dunha consulta a outra
                //temos que facelo sobre o dataset non sobre o control
                //non ten sentido borrar a colecion tables do dataset completa porque so queremos que borre a taboa concreta
                //dtsSociedad.Tables.Clear();
                //un control enlazado nunca se modifica perse hai que ir o dataset
                if (flag2 == true) { 
                    lblNsocio.DataBindings.Add("Text", dtsSociedad.Tables["soc"], "NSocio");
                    lblNif.DataBindings.Add("Text", dtsSociedad.Tables["soc"], "Nif");
                    lblNombre.DataBindings.Add("Text", dtsSociedad.Tables["soc"], "Nombre");
                    dtdata.DataBindings.Add("Value", dtsSociedad.Tables["soc"], "FechaAlta");
                    chkBaixa.DataBindings.Add("Checked", dtsSociedad.Tables["soc"], "Baja");
                    cmbTipo2.DataBindings.Add("Text", dtsSociedad.Tables["soc"], "TipoSocio");
                    
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
                novo.cmbBenef.Visible = false;
                novo.cmbTipos.Visible = true;
                //curioso como a condicion dun if pode funcionar como disparador
                if (novo.ShowDialog() == DialogResult.OK)
                {
                   
                        StructSoc.cnn.Open();
                        dtr = dtsSociedad.Tables["soc"].NewRow();
                        dtr["NSocio"] = obterUltimo("NSocio","Socios"); //coidado cos tipos das bbdd e os controles
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

            mnuModifica.Click += (sender, even) => {
                if (valida()) return;
                FrmAux aux = new FrmAux();
                aux.Name = "Modifica Usuario";
                aux.lblNumeroSocio.Visible = true;
                aux.label4.Visible = true;

                //lblNsocio.DataBindings.Add("Text", dtsSociedad.Tables["soc"], "NSocio");
                aux.lblNumeroSocio.Text = lblNsocio.Text;
                aux.txtNif.Text = lblNif.Text;
                aux.txtNombre.Text = lblNombre.Text;
                aux.dtpData.Value = dtdata.Value;
                aux.chkBaixa.Checked = chkBaixa.Checked;
                List<object> o = new List<object>();
                foreach (var v in cmbTipo2.Items) {
                    o.Add(v);
                }
                aux.cmbTipos.Items.AddRange(o.ToArray());

                if (aux.ShowDialog() == DialogResult.OK)
                {
                    DataRow[] drw = dtsSociedad.Tables["Soc"].Select(string.Format("NSocio= {0}",aux.lblNumeroSocio.Text));


                    drw[0]["FechaAlta"] = aux.dtpData.Value;
                    drw[0]["Baja"] = aux.chkBaixa.Checked;
                    drw[0]["TipoSocio"] = aux.cmbTipos.Text[0];
                    adaSoc.Update(dtsSociedad, "soc");
                    dtsSociedad.AcceptChanges();
                }
                else
                {
                    return;
                }
                StructSoc.cnn.Close();
            };

            mnuNovoBen.Click += (sender, even) => {
                if (valida()) return;
                FrmAux aux = new FrmAux();
                aux.Name = "Novo Beneficiario";
                DataRow dtr;
                //temos que ter o builder para facer crud
                aux.cmbBenef.Visible = true;
                aux.cmbTipos.Visible = false;
                aux.cmbBenef.DataBindings.Add("Text", dtsSociedad.Tables["Benef"],"TipoSocio");
                cmbBuildBenef = new OleDbCommandBuilder(adaBen);
                if (aux.ShowDialog() == DialogResult.OK)
                {

                    StructSoc.cnn.Open();
                    dtr = dtsSociedad.Tables["Benef"].NewRow();
                    dtr["NSocio"] = short.Parse(lblNsocio.Text); //coidado cos tipos das bbdd e os controles
                    dtr["NBenef"] = obterUltimo("NBenef","Beneficiarios");
                    dtr["NIF"] = aux.txtNif.Text;
                    dtr["Nombre"] = aux.txtNombre.Text;
                    dtr["FechaAlta"] = aux.dtpData.Value;
                    dtr["Baja"] = aux.chkBaixa.Checked;
                    dtr["TipoSocio"] = aux.cmbTipos.SelectedValue; //porque é o que esta na fila selecionado o selected item danos toda a fila row

                    dtsSociedad.Tables["Benef"].Rows.Add(dtr);
                    adaBen.Update(dtsSociedad, "Benef");
                    dtsSociedad.AcceptChanges();
                    StructSoc.cnn.Close();
                }
                else
                {
                    return;
                }
            };

            mnuCuota.Click += (sender, even) => {
                if (valida()) return;
                OleDbCommand cmm = new OleDbCommand(string.Format("SELECT SUM(Cuotas.Cuota) AS Expr1 FROM((Socios INNER JOIN Beneficiarios ON Socios.NSocio = Beneficiarios.NSocio) INNER JOIN Cuotas ON Cuotas.TipoSocio = Beneficiarios.TipoSocio) WHERE(Beneficiarios.Baja = false and Beneficiarios.NSocio = {0}) GROUP BY Beneficiarios.NSocio",lblNsocio.Text), StructSoc.cnn); //vamos a bbdd e non o dataset para non crear inconsistencias
                
                StructSoc.cnn.Open();
                cmm.ExecuteScalar();
                lblCuouta.Text = cmm.ExecuteScalar().ToString();

                lblCuouta.Text = (int.Parse(lblCuouta.Text) + 25).ToString();//porque falta o titular que sempre é 25
                StructSoc.cnn.Close();
            };
        }

        private short obterUltimo(string campo,string taboa) {
            OleDbCommand cmm = new OleDbCommand(string.Format("Select max({0}) from {1}",campo,taboa),StructSoc.cnn); //vamos a bbdd e non o dataset para non crear inconsistencias
            object o;          
                //StructSoc.cnn.Open();
                o = cmm.ExecuteScalar();
                StructSoc.cnn.Close();
            return o == DBNull.Value ? (short)1 : (short)(short.Parse(o.ToString()) + ((short)1));
        }

        private bool valida() {
            
            if (cmbSocio.Text == "") {
                MessageBox.Show("Faltan datos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }        
    }
}
