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
using System.IO;//para facer uso de streamwriter e o streamreader


namespace ListaMultiple
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            //asi dicimos que pode ser nulo
            //int? b;
            InitializeComponent();
            this.btnPasaSele.Click += new EventHandler(Selecion);
            this.btnPasaTodos.Click += new EventHandler(Todos);
            this.btnQuitarS.Click += new EventHandler(Selecion);
            this.btnQuitarT.Click += new EventHandler(Todos);
            //asociamos o click a abrir o dialog
            this.btnElexirImaxen.Click += (object sender, EventArgs e) =>
            {

                //podemos co filter indicar os formatos validos
                //aqui o formato é descripcion pipe extension
                //teriamos que filtrar a entrada por se mete patrons tipo *.*

                dlgDialogoAbrir.Filter = "Mapa de bits|*.bmp|jpgs|*.jpg|png's|*.png";
                try
                {
                    //e lle da a o boton positivo
                    if (dlgDialogoAbrir.ShowDialog() == DialogResult.OK)
                    {
                        //asociamos a elecion do dialog o image

                        pictureBox1.Image = Image.FromFile(dlgDialogoAbrir.FileName);
                    }
                }//capturar excepcions xerales non é boa idea
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("non é unha imaxe valida");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro xeral");
                }
            };

            this.mnuCargar.Click += (object sender, EventArgs e) => {
                lstPresentados.Items.Clear();
                lstContratados.Items.Clear();
                StreamReader strReader = new StreamReader("alumnos.txt");
                while (!strReader.EndOfStream) {
                    lstPresentados.Items.Add(strReader.ReadLine());
                }
                strReader.Close();
                StreamReader strReaderCon = new StreamReader("contratados.txt");
                while (!strReaderCon.EndOfStream)
                {
                    lstContratados.Items.Add(strReaderCon.ReadLine());
                }
                strReaderCon.Close();
            };

            this.mnuGuardar.Click += (object sender, EventArgs e) => {
                //sempre que abramos non manten o contido??????!!!!
                StreamWriter strEscribe = new StreamWriter("alumnos.txt",false,System.Text.Encoding.Unicode);
                foreach (var v in lstPresentados.Items) {
                    strEscribe.WriteLine(v.ToString());
                }
                strEscribe.Close();
                StreamWriter strEscribeCon = new StreamWriter("contratados.txt", false, System.Text.Encoding.Unicode);
                foreach (var v in lstContratados.Items)
                {
                    strEscribeCon.WriteLine(v.ToString());
                }
                strEscribeCon.Close();

                MessageBox.Show("Os datos foron gardados","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            };


            this.mnuSalir.Click += (object sender, EventArgs e) => {
                //so cerramos o formulario acutual
                this.Close();
                
            };

        }

        public void Selecion(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name.Equals(btnPasaSele.Name))
            {
                foreach (var v in lstPresentados.SelectedItems)
                {
                    lstContratados.Items.Add(v);
                }



                for (int n = 0; n < lstPresentados.SelectedItems.Count; )
                {
                    //non temos necesidade de incrementar o indice xa que unha vez removido
                    //o count xa se decrementa so
                    //temo que quitar con removeat se non os duplicados machacamos
                    //é equivalente usar a notacion de array ou o indexOf
                    lstPresentados.Items.RemoveAt(lstPresentados.SelectedIndices[0]);
                }

            }
            else
            {

                foreach (var v in lstContratados.SelectedItems)
                {
                    lstPresentados.Items.Add(v);
                }

                for (int n = 0; n < lstContratados.SelectedItems.Count; )
                {
                    lstContratados.Items.RemoveAt(lstContratados.SelectedIndices[0]);
                }
            }
        }

        public void Todos(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Name.Equals(btnPasaTodos.Name))
            {
                lstContratados.Items.AddRange(lstPresentados.Items);
                lstPresentados.Items.Clear();
            }
            else
            {
                lstPresentados.Items.AddRange(lstContratados.Items);
                lstContratados.Items.Clear();
            }
        }


    }
}
