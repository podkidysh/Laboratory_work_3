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

namespace Laboratory_work_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btNewGame_Click(object sender, RoutedEventArgs e)
        {
            Forms.NewGameWindow newGame = new Forms.NewGameWindow();
            newGame.Show();
            Close();
        }

        private void btRunGame_Click(object sender, RoutedEventArgs e)
        {
            Forms.RunGameWindow RunGame = new Forms.RunGameWindow();
            RunGame.Show();
            Close();
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
