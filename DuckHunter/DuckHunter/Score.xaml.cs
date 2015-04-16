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
using System.Threading;
using System.Diagnostics;

namespace DuckHunter
{
    /// <summary>
    /// Interaction logic for Score.xaml
    /// </summary>
    public partial class Score : Window
    {
        public Score(string ScoreCount)
        {
            InitializeComponent();

            lblScoreCount.Content = ScoreCount;
            
        }

        private void lblReiniciar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void lblQuit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
