﻿using System;
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
using System.Threading;

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





        //>>>>>>>>>>>>   PATO 1   <<<<<<<<<<<<<

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






        //>>>>>>>>>>>>   PATO 2   <<<<<<<<<<<<<

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





        //>>>>>>>>>>>>   PATO 3   <<<<<<<<<<<<<

        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 3<<<<<<<<<<<<<

        private void Pato3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO QUARTO PATO
            Pato4.LoadedBehavior = MediaState.Play;
            Pato4_BeginStoryboard.Storyboard.Begin();

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





        //>>>>>>>>>>>>   PATO 4   <<<<<<<<<<<<<

        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 4<<<<<<<<<<<<<

        private void Pato4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO Quinto PATO
            Pato5.LoadedBehavior = MediaState.Play;
            Pato5_BeginStoryboard.Storyboard.Begin();

            //PATO RECEBE A IMAGEM DA EXPLOSÃO

            Pato4.Source = Explosao.Source;
            Pato4.Volume = 0;
            cont++;

            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 1)
            {
                sb_Patinho4_BeginStoryboard.Storyboard.Begin();
            }

            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR


            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato4.Visibility = Visibility.Hidden;
        }









        //>>>>>>>>>>>>   PATO 5   <<<<<<<<<<<<<


        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 5<<<<<<<<<<<<<


        private void Pato5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO SEXTO PATO
            Pato6.LoadedBehavior = MediaState.Play;
            Pato6_BeginStoryboard.Storyboard.Begin();

            //PATO RECEBE A IMAGEM DA EXPLOSÃO

            Pato5.Source = Explosao.Source;
            Pato5.Volume = 0;
            cont++;

            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 1)
            {
                sb_Patinho5_BeginStoryboard.Storyboard.Begin();
            }

            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR


            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato5.Visibility = Visibility.Hidden;
        }





        //>>>>>>>>>>>>   PATO 6   <<<<<<<<<<<<<


        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 6<<<<<<<<<<<<<


        private void Pato6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO SÉTIMO PATO
            Pato7.LoadedBehavior = MediaState.Play;
            Pato7_BeginStoryboard.Storyboard.Begin();

            //PATO RECEBE A IMAGEM DA EXPLOSÃO

            Pato6.Source = Explosao.Source;
            Pato6.Volume = 0;
            cont++;

            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 1)
            {
                sb_Patinho6_BeginStoryboard.Storyboard.Begin();
            }

            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR


            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato6.Visibility = Visibility.Hidden;
        }






        //>>>>>>>>>>>>   PATO 7   <<<<<<<<<<<<<


        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 7<<<<<<<<<<<<<



        private void Pato7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO OITAVO PATO
            Pato8.LoadedBehavior = MediaState.Play;
            Pato8_BeginStoryboard.Storyboard.Begin();

            //PATO RECEBE A IMAGEM DA EXPLOSÃO

            Pato7.Source = Explosao.Source;
            Pato7.Volume = 0;
            cont++;

            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 1)
            {
                sb_Patinho7_BeginStoryboard.Storyboard.Begin();
            }

            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR


            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato7.Visibility = Visibility.Hidden;
        }







        //>>>>>>>>>>>>   PATO 8   <<<<<<<<<<<<<


        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 8<<<<<<<<<<<<<



        private void Pato8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO NONO PATO
            Pato9.LoadedBehavior = MediaState.Play;
            Pato9_BeginStoryboard.Storyboard.Begin();

            //PATO RECEBE A IMAGEM DA EXPLOSÃO

            Pato8.Source = Explosao.Source;
            Pato8.Volume = 0;
            cont++;

            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 1)
            {
                sb_Patinho8_BeginStoryboard.Storyboard.Begin();
            }

            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR


            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato8.Visibility = Visibility.Hidden;
        }









        //>>>>>>>>>>>>   PATO 9   <<<<<<<<<<<<<


        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 9<<<<<<<<<<<<<




        private void Pato9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO DÉCIMO PATO
            Pato10.LoadedBehavior = MediaState.Play;
            Pato10_BeginStoryboard.Storyboard.Begin();

            //PATO RECEBE A IMAGEM DA EXPLOSÃO

            Pato9.Source = Explosao.Source;
            Pato9.Volume = 0;
            cont++;

            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 1)
            {
                sb_Patinho9_BeginStoryboard.Storyboard.Begin();
            }

            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR


            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato9.Visibility = Visibility.Hidden;
        }






        //>>>>>>>>>>>>   PATO 10   <<<<<<<<<<<<<


        //EVENTO DO CLICK DO MOUSE NO >>>>>>>>>>>>PATO 10<<<<<<<<<<<<<


        private void Pato10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //EFETUA O PLAY DO DÉCIMO PATO
            //Pato10.LoadedBehavior = MediaState.Play;
            //Pato10_BeginStoryboard.Storyboard.Begin();

            //PATO RECEBE A IMAGEM DA EXPLOSÃO

            Pato10.Source = Explosao.Source;
            Pato10.Volume = 0;
            cont++;

            //CONTAGEM DE SCORE
            int var = Convert.ToInt32(lblScore.Content);
            lblScore.Content = Convert.ToString(var + 1);

            //EXECUTA A ANIMAÇÃO DO PATINHO AMARELO

            if (cont > 1)
            {
                sb_Patinho10_BeginStoryboard.Storyboard.Begin();
            }

            //INCREMENTA TEMPO PARA A EXPLOSÃO TERMINAR


            // Pato1.LoadedBehavior = MediaState.Manual;
            for (int i = 0; i < 90000000; i++)
            {

            }
            Pato10.Visibility = Visibility.Hidden;
        }

        private void Pato1_Initialized(object sender, EventArgs e)
        {
            //Thread.Sleep(7000);
            //if (cont == 0)
            //{
                //lblTenteOutraVez.Visibility = Visibility.Visible;
                //lblAperteEnter.Visibility = Visibility.Visible;
            //}

        }

        private void Pato1_Loaded(object sender, RoutedEventArgs e)
        {
            //for (int i = 0; i < 90000000; i++)
           // {

           // }
         //   if (cont == 0)
         //   {
         //       lblTenteOutraVez.Visibility = Visibility.Visible;
        //        lblAperteEnter.Visibility = Visibility.Visible;
         //   }
        }



        /* public void Pato1_MediaEnded()
         {
             //Pato1.Stop();
             Pato1.Position = new TimeSpan(0, 0, 2);
             //Pato1.Visibility = Visibility.Hidden;
         }*/



    }
}
