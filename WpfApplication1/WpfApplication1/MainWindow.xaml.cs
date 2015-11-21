using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WpfApplication1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int cont = 0;
        int valor = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            btn.Click += (sender, enven) => {
                cont++;
                ((Button)sender).Content = (cont).ToString();
                for (int i = 0; i < 10; i++) {
                    valor += i;
                    progreso.Value = valor/3; 
                
                }
            };
            //podemos facelo asi pero tamen podemos chamar a opcion en xaml que vincule o metodo co boton
            btn.MouseRightButtonDown += (sender, even) => {
                //Button b = sender as Button; //investigalo xa que evita o casteo Button b = ((Button)sender)
                //para adicionar o window ten unha propiedade content NON RECOMENDADO XA QUE ROMPEMOS O MVVM OU MVC
                valor = 0;
                progreso.Value /=  3;
            };
            
            
        }

        //en vb temos a posivilidade de usar o handles e a propiedade click do control no xaml
        //como é un delegate podemos vincular varios metodos o mesmo evento button.click ou o handler no xml que vicule co metodo da clase
        public void clica(object sender, EventArgs e) {
            MessageBox.Show("kk");
        }
    }
}
