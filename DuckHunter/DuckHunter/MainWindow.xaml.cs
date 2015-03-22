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

namespace DuckHunter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // Tocar_Som();
        }

        //  private void Tocar_Som()
        // {
        //        SoundPlayerAction som = new SoundPlayerAction("Patos_no_Lago";  @"E:\C\DuckHunter\Sons\Patos_no_Lago.wav");
        //         som.Source {; @"E:\C\DuckHunter\Sons\Patos_no_Lago.wav" };
        //    }
        int cont = 0;

        public void Pato1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Pato2.LoadedBehavior = MediaState.Play;
            Pato1.Source = Explosao.Source;
            Pato1.Volume = 0;
            cont++;
            if (cont > 0)
            {
                sb_Patinho1_BeginStoryboard.Storyboard.Begin();
            }

            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato1.Visibility = Visibility.Hidden;
        }


        public void Pato2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Pato2.Source = Explosao.Source;
            Pato2.Volume = 0;
            cont++;
            if (cont > 1)
            {
                sb_Patinho2_BeginStoryboard.Storyboard.Begin();
            }

            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato2.Visibility = Visibility.Hidden;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToInt32(Tiros.Content) > 0)
            {
                int var = Convert.ToInt32(Tiros.Content);
                Tiros.Content = Convert.ToString(var - 1);
            }
            else
            {
                Reload.Visibility = Visibility.Visible;
            }
        }

        private void Window_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (Convert.ToBoolean(Key.Space))
            {
                Tiros.Content = 8;
                Reload.Visibility = Visibility.Hidden;
            }
        }

        /* public void Pato1_MediaEnded()
         {
             //Pato1.Stop();
             Pato1.Position = new TimeSpan(0, 0, 2);
             //Pato1.Visibility = Visibility.Hidden;
         }*/



    }
}
