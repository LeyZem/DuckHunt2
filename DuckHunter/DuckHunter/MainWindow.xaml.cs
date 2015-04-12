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
            var myCursor = new Cursor(@"C:\Users\Thiago Diniz\Documents\GitHub\DuckHunt2\DuckHunter\DuckHunter\MiraDuckHunt.ani");
            this.Cursor = myCursor;
        }

        //  private void Tocar_Som()
        // {
        //        SoundPlayerAction som = new SoundPlayerAction("Patos_no_Lago";  @"E:\C\DuckHunter\Sons\Patos_no_Lago.wav");
        //         som.Source {; @"E:\C\DuckHunter\Sons\Patos_no_Lago.wav" };
        //    }
        int cont = 0;





        //>>>>>>>>>>>>PATO 1<<<<<<<<<<<<<

        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 1<<<<<<<<<<<<<


        public void Pato1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            //EFETUA O PLAY DO SEGUNDO PATO
            Pato2.LoadedBehavior = MediaState.Play;

            //PATO RECEBE A IMAGEM DA EXPLOSÃO
            Pato1.Source = Explosao.Source;
            Pato1.Volume = 0;
            cont++;
            
            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 0)
            {
                sb_Patinho1_BeginStoryboard.Storyboard.Begin();
            }


            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR

            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato1.Visibility = Visibility.Hidden;
        }






        //>>>>>>>>>>>>PATO 2<<<<<<<<<<<<<

        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 2<<<<<<<<<<<<<

        public void Pato2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO TERCEIRO PATO
            Pato3.LoadedBehavior = MediaState.Play;
            Pato3_BeginStoryboard.Storyboard.Begin();

            //PATO RECEBE A IMAGEM DA EXPLOSÃO

            Pato2.Source = Explosao.Source;
            Pato2.Volume = 0;
            cont++;

            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 1)
            {
                sb_Patinho2_BeginStoryboard.Storyboard.Begin();
            }

            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR


            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato2.Visibility = Visibility.Hidden;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            //DIMINUI A QUANTIDADE DE TIROS AO CLICAR O MOUSE
            //VERIFICA SE O CARREGADOR ESTÁ VAZIO

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
            //RECARREGA A MUNIÇÃO AO APERTAR A TECLA ESPAÇO

            if (Convert.ToBoolean(Key.Space))
            {
                Tiros.Content = 8;
                Reload.Visibility = Visibility.Hidden;
            }
        }



        //>>>>>>>>>>>>PATO 2<<<<<<<<<<<<<

        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 2<<<<<<<<<<<<<

        private void Pato3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO QUARTO PATO
            //Pato3.LoadedBehavior = MediaState.Play;

            //PATO RECEBE A IMAGEM DA EXPLOSÃO

            Pato3.Source = Explosao.Source;
            Pato3.Volume = 0;
            cont++;

            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 1)
            {
                sb_Patinho3_BeginStoryboard.Storyboard.Begin();
            }

            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR


            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato3.Visibility = Visibility.Hidden;
        }



        /* public void Pato1_MediaEnded()
         {
             //Pato1.Stop();
             Pato1.Position = new TimeSpan(0, 0, 2);
             //Pato1.Visibility = Visibility.Hidden;
         }*/



    }
}
