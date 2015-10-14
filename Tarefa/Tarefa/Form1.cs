using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Tarefa
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> valores = new Dictionary<string, int>();
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
            this.btnMais.Click += (object sender, EventArgs e) => {
                if (lstAlumnos.Items.Count != 0)
                {
                    if (lstAlumnos.SelectedItem != null)
                    {
                        if (lstVotados.FindStringExact(lstAlumnos.SelectedItem.ToString()) == ListBox.NoMatches)
                        {
                            valores.Add(lstAlumnos.SelectedItem.ToString(),1);
                            lstVotados.Items.Add(lstAlumnos.SelectedItem);
                            lstVotos.Items.Add(valores[lstAlumnos.SelectedItem.ToString()]);
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


        }
    }
}
