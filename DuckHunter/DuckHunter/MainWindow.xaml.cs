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

        public void Pato1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            //Pato1.Visibility = Visibility.Hidden;
            Pato1.Source = Explosao.Source;
            Pato1.IsMuted = true;
            //Explosao.Volume = '0.0';
            
           // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato1.Visibility = Visibility.Hidden;
            //Pato1_MediaEnded();

        }

        public void Pato1_Reinicia()
        {
            // onde mediaElementVideo é o component MediaElement
            Pato1.Position = new TimeSpan(0, 0, 0);
        }

        /* public void Pato1_MediaEnded()
         {
             //Pato1.Stop();
             Pato1.Position = new TimeSpan(0, 0, 2);
             //Pato1.Visibility = Visibility.Hidden;
         }*/

        

    }
}
