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

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для CafeWindow.xaml
    /// </summary>
    public partial class CafeWindow : Window
    {
        public CafeWindow()
        {
            InitializeComponent();
        }

        private void btLightEat_Click(object sender, RoutedEventArgs e)
        {
            if (App.myGamer.Satiety == 100)
            {
                MessageBox.Show("Вы максимально сыты");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
            else if (App.myGamer.Money >= 10)
            {
                App.myGamer.Money -= 10;
                if (App.myGamer.Satiety > 90)
                {
                    App.myGamer.Satiety = 100;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы успешно перекусили");
                    App.myGamer.Satiety += 3;
                    App.myGamer.Fatigue += 5;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("У вас не хватает денег");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
        }

        private void btMiddleEat_Click(object sender, RoutedEventArgs e)
        {
            if (App.myGamer.Satiety == 100)
            {
                MessageBox.Show("Вы максимально сыты");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
            else if (App.myGamer.Money >= 25)
            {
                App.myGamer.Money -= 25;
                if (App.myGamer.Satiety > 93)
                {
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы успешно перекусили");
                    App.myGamer.Satiety += 25;
                    App.myGamer.Fatigue += 10;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("У вас не хватает денег");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
        }

        private void btGoodEat_Click(object sender, RoutedEventArgs e)
        {
            if (App.myGamer.Satiety == 100)
            {
                MessageBox.Show("Вы максимально сыты");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
            else if (App.myGamer.Money >= 10)
            {
                App.myGamer.Money -= 50;
                if (App.myGamer.Satiety > 50)
                {
                    App.myGamer.Satiety = 100;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы успешно перекусили");
                    App.myGamer.Satiety += 50;
                    App.myGamer.Fatigue += 25;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("У вас не хватает денег");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }
    }
}
