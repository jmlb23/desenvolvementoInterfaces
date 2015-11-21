using System;
using System.Windows;
using System.Windows.Media.Imaging;


namespace Dados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnXogador1.Click += (sender, even) => {
                lstXogadorUn.Items.Add(chou());
                btnXogador1.IsEnabled = false;
                btnXogador2.IsEnabled = true;
            };
            btnXogador2.Click += (sender, even) => {
                lstXogadorDous.Items.Add(chou());
                btnXogador2.IsEnabled = false;
                btnXogador1.IsEnabled = true;
            };
        }

        public int chou() {
            Random r = new Random();

            int valor = r.Next(1,6);

            switch (valor)
            {
                case 1:
                    imgDado.Source = new BitmapImage(new Uri(@"E:\proyectos\Dados\Dados\images\DadoR1.bmp"));
                    return valor;
                case 2:
                    imgDado.Source = new BitmapImage(new Uri(@"E:\proyectos\Dados\Dados\images\DadoR2.bmp"));
                    return valor;
                case 3:
                    imgDado.Source = new BitmapImage(new Uri(@"E:\proyectos\Dados\Dados\images\DadoR3.bmp"));
                    return valor;
                case 4:
                    imgDado.Source = new BitmapImage(new Uri(@"E:\proyectos\Dados\Dados\images\DadoR4.bmp"));
                    return valor;
                case 5:
                    imgDado.Source = new BitmapImage(new Uri(@"E:\proyectos\Dados\Dados\images\DadoR5.bmp"));
                    return valor;
                case 6:
                    imgDado.Source = new BitmapImage(new Uri(@"E:\proyectos\Dados\Dados\images\DadoR6.bmp"));
                    return valor;
            }

            return 0;
        }
    }
}
