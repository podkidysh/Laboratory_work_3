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
    /// Логика взаимодействия для WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        public WorkWindow()
        {
            InitializeComponent();
            List<Model.Work> works = new List<Model.Work>
            {
                 new Model.Work{ Name = "Практика дома"  , Minqualifications = 0 , Wages = 0 , UpExperience = 1} ,
                 new Model.Work{ Name = "Оператор ЭВМ"  , Minqualifications = 10 , Wages = 20 , UpExperience = 2} ,
                 new Model.Work{ Name = "Фриланс"  , Minqualifications = 50 , Wages = 50 , UpExperience = 5} ,
                 new Model.Work{ Name = "Разработчик мобильных приложений"  , Minqualifications = 100 , Wages = 100  , UpExperience = 10} ,
                 new Model.Work{ Name = "Разработчик компьютерных игр"  , Minqualifications = 250 , Wages = 250 , UpExperience = 25} ,
                 new Model.Work{ Name = "Web-разработчик"  , Minqualifications = 500 , Wages = 500 , UpExperience = 50} ,
                 new Model.Work{ Name = "Программист Яндекса"  , Minqualifications = 1000 , Wages = 1000 , UpExperience = 100} ,
                 new Model.Work{ Name = "Программист Microsoft"  , Minqualifications = 2500 , Wages = 2500 , UpExperience = 250} ,
                 new Model.Work{ Name = "Программист Google"  , Minqualifications = 5000 , Wages = 5000 , UpExperience = 500} ,
                 new Model.Work{ Name = "Своя IT-компания"  , Minqualifications = 10000 , Wages = 10000 , UpExperience = 1000} ,
            };

            listWork.ItemsSource = works;
        }

        private void btWorking_Click(object sender, RoutedEventArgs e)
        {
            Model.Work work = listWork.SelectedItem as Model.Work;

            if (work.Minqualifications <= App.myWork.Experience)
            {
                App.myWork.Name = work.Name;
                App.myWork.Wages = work.Wages;
                App.myWork.UpExperience = work.UpExperience;
                GameWindow gameWingdow = new GameWindow();
                gameWingdow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Вы не можете устроиться на эту работу");
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
