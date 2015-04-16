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
using System.Windows.Shapes;

namespace DuckHunter
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

		private void lblGameA_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			MainWindow frmJogoA = new MainWindow();
			frmJogoA.Show();
			Close();
		}

		private void lblGameB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			//Não Definido ainda o Modo de Jogo B
		}

        private void lblQuit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void lblSobre_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Sobre frmSobre = new Sobre();
            frmSobre.Show();
        }
    }
}
