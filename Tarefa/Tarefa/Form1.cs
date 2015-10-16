using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Tarefa
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            this.mnuCarga.Click += (object sender, EventArgs e) => {
                //para que cerre o recurso
                try
                {
                    using (StreamReader stLee = new StreamReader("../../recursos/Alumnos.txt"))
                        while (!stLee.EndOfStream)
                        {
                            lstAlumnos.Items.Add(stLee.ReadLine());
                        }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Non existe o arquivo a ler","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            };

            //o igual que en java as lambdas infiren os tipos dos argumentos segundo o contexto
            this.mnuGraba.Click += (sender,  e) => {
                using (StreamWriter strW = new StreamWriter("../../recursos/Escrutinio.txt")) {
                    if (lstVotados.Items.Count!=0)
                    {
                        foreach (var val in lstVotados.Items)
                        {
                            int indice = lstVotados.FindStringExact(val.ToString());
                            strW.WriteLine(string.Format("{0}|{1}", lstVotados.Items[indice], lstVotos.Items[indice]));
                        }
                        MessageBox.Show("Datos gardados con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Non hai datos\nqueres gardar igual?", "informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
                            strW.WriteLine();
                        }
                        
                    }
                }
            };
            this.mnuSalir.Click += (sender, e) => {
                this.Close();
            };
            this.mnuOrdena.Click += (sender, e) => {
                if (lstVotados.Items.Count != 0)
                {
                    SortedList<string, int> valores = new SortedList<string, int>();

                    foreach (var val in lstVotados.Items)
                    {
                        int indice = lstVotados.FindStringExact(val.ToString());
                        valores.Add(lstVotados.Items[indice].ToString(), int.Parse(lstVotos.Items[indice].ToString()));
                    }
                    lstVotados.Items.Clear();
                    lstVotos.Items.Clear();
                    foreach (var v in valores.OrderBy(x => -x.Value))
                    {
                        lstVotados.Items.Add(v.Key);
                        lstVotos.Items.Add(v.Value);
                    }
                    txtNomeDelegado.Text = lstVotados.Items[0].ToString();
                    txtVotosDelegado.Text = lstVotos.Items[0].ToString();
                    txtNomeSubdele.Text = lstVotados.Items[1].ToString();
                    txtVotosSubdele.Text = lstVotos.Items[1].ToString();
                }
                else 
                {
                    MessageBox.Show("Non hai datos para ordenar","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);                
                }
            };
            this.btnOrdena.Click += (sender, e) => {
                if (lstVotados.Items.Count != 0)
                {
                    SortedList<string, int> valores = new SortedList<string, int>();

                    foreach (var val in lstVotados.Items)
                    {
                        int indice = lstVotados.FindStringExact(val.ToString());
                        valores.Add(lstVotados.Items[indice].ToString(), int.Parse(lstVotos.Items[indice].ToString()));
                    }
                    lstVotados.Items.Clear();
                    lstVotos.Items.Clear();
                    foreach (var v in valores.OrderBy(x => -x.Value))
                    {
                        lstVotados.Items.Add(v.Key);
                        lstVotos.Items.Add(v.Value);
                    }
                    txtNomeDelegado.Text = lstVotados.Items[0].ToString();
                    txtVotosDelegado.Text = lstVotos.Items[0].ToString();
                    txtNomeSubdele.Text = lstVotados.Items[1].ToString();
                    txtVotosSubdele.Text = lstVotos.Items[1].ToString();
                }
                else
                {
                    MessageBox.Show("Non hai datos para ordenar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            this.btnMais.Click += (object sender, EventArgs e) => {
                if (lstAlumnos.Items.Count != 0)
                {
                    if (lstAlumnos.SelectedItem != null)
                    {
                        if (lstVotados.FindStringExact(lstAlumnos.SelectedItem.ToString()) == ListBox.NoMatches)
                        {
                            
                            lstVotados.Items.Add(lstAlumnos.SelectedItem);
                            lstVotos.Items.Add(1);
                        }
                        else
                        {
                            lstVotos.Items[lstVotados.FindStringExact(lstAlumnos.SelectedItem.ToString())] = int.Parse(lstVotos.Items[lstVotados.FindStringExact(lstAlumnos.SelectedItem.ToString())].ToString())+1;
                        }
                    }
                    else MessageBox.Show("Seleciona un", "Seleciona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Non hai alumnos\ncarga os datos","Carga",MessageBoxButtons.OK,MessageBoxIcon.Information);
            };

            this.btnMenos.Click += (object sender, EventArgs e) => {
                if (lstVotados.Items.Count != 0)
                {
                    if (lstVotados.SelectedItem != null)
                    {
                        
                        lstVotos.Items[lstVotados.SelectedIndex] = int.Parse(lstVotos.Items[lstVotados.SelectedIndex].ToString()) -1;
                        if (lstVotos.Items[lstVotados.SelectedIndex].ToString().Equals("0"))
                        {
                            lstVotos.Items.RemoveAt(lstVotados.SelectedIndex);
                            lstVotados.Items.RemoveAt(lstVotados.SelectedIndex);
                            
                        }
                        
                    }
                    else MessageBox.Show("Seleciona un", "Seleciona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Non hai alumnos\ncarga os datos", "Carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };


        }
    }
}
