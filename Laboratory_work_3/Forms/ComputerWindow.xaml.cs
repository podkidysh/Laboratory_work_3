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
    /// Логика взаимодействия для ComputerWindow.xaml
    /// </summary>
    public partial class ComputerWindow : Window
    {
        Model.Computer Computer;
        public ComputerWindow()
        {
            InitializeComponent();

            Computer = App.myComputer;
            gridComputerInfo.DataContext = Computer;
        }

        private void btUpgrade1_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Processor == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Processor += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }
                
                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade2_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.VideoCard == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.VideoCard += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade3_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.RamMemory == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.RamMemory += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade4_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.SSD == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.SSD += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade5_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Cooling == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Cooling += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
            
        }

        private void btUpgrade6_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Motherboard == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Motherboard += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade7_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.PowerSupply == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.PowerSupply += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade8_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Body == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Body += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btCreateWebSite_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 25;
            App.myWork.Experience += 10;
            MessageBox.Show("Вы выполнили разработку");
            if (App.myComputer.Processor == 2 && App.myComputer.VideoCard == 2 && App.myComputer.RamMemory == 2 && App.myComputer.SSD == 2 &&
                App.myComputer.Cooling == 2 && App.myComputer.Motherboard == 2 && App.myComputer.PowerSupply == 2 && App.myComputer.Body == 2)
            {
                App.myGamer.Fatigue -= 3;
            }
            else if (App.myComputer.Processor == 3 && App.myComputer.VideoCard == 3 && App.myComputer.RamMemory == 3 && App.myComputer.SSD == 3 &&
                App.myComputer.Cooling == 3 && App.myComputer.Motherboard == 3 && App.myComputer.PowerSupply == 3 && App.myComputer.Body == 3)
            {
                App.myGamer.Fatigue -= 5;
            }
            else if (App.myComputer.Processor == 4 && App.myComputer.VideoCard == 4 && App.myComputer.RamMemory == 4 && App.myComputer.SSD == 4 &&
                App.myComputer.Cooling == 4 && App.myComputer.Motherboard == 4 && App.myComputer.PowerSupply == 4 && App.myComputer.Body == 4)
            {
                App.myGamer.Fatigue -= 10;
            }
            else if (App.myComputer.Processor == 5 && App.myComputer.VideoCard == 5 && App.myComputer.RamMemory == 5 && App.myComputer.SSD == 5 &&
                App.myComputer.Cooling == 5 && App.myComputer.Motherboard == 5 && App.myComputer.PowerSupply == 5 && App.myComputer.Body == 5)
            {
                App.myGamer.Fatigue -= 15;
            }
        }

        private void btCreateGame_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 50;
            App.myWork.Experience += 25;
            MessageBox.Show("Вы выполнили разработку");
            if (App.myComputer.Processor == 2 && App.myComputer.VideoCard == 2 && App.myComputer.RamMemory == 2 && App.myComputer.SSD == 2 &&
                App.myComputer.Cooling == 2 && App.myComputer.Motherboard == 2 && App.myComputer.PowerSupply == 2 && App.myComputer.Body == 2)
            {
                App.myGamer.Fatigue -= 3;
            }
            else if (App.myComputer.Processor == 3 && App.myComputer.VideoCard == 3 && App.myComputer.RamMemory == 3 && App.myComputer.SSD == 3 &&
                App.myComputer.Cooling == 3 && App.myComputer.Motherboard == 3 && App.myComputer.PowerSupply == 3 && App.myComputer.Body == 3)
            {
                App.myGamer.Fatigue -= 5;
            }
            else if (App.myComputer.Processor == 4 && App.myComputer.VideoCard == 4 && App.myComputer.RamMemory == 4 && App.myComputer.SSD == 4 &&
                App.myComputer.Cooling == 4 && App.myComputer.Motherboard == 4 && App.myComputer.PowerSupply == 4 && App.myComputer.Body == 4)
            {
                App.myGamer.Fatigue -= 10;
            }
            else if (App.myComputer.Processor == 5 && App.myComputer.VideoCard == 5 && App.myComputer.RamMemory == 5 && App.myComputer.SSD == 5 &&
                App.myComputer.Cooling == 5 && App.myComputer.Motherboard == 5 && App.myComputer.PowerSupply == 5 && App.myComputer.Body == 5)
            {
                App.myGamer.Fatigue -= 15;
            }
        }

        private void btCreateMobileApp_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 75;
            App.myWork.Experience += 50;
            MessageBox.Show("Вы выполнили разработку");
            if (App.myComputer.Processor == 2 && App.myComputer.VideoCard == 2 && App.myComputer.RamMemory == 2 && App.myComputer.SSD == 2 &&
                App.myComputer.Cooling == 2 && App.myComputer.Motherboard == 2 && App.myComputer.PowerSupply == 2 && App.myComputer.Body == 2)
            {
                App.myGamer.Fatigue -= 3;
            }
            else if (App.myComputer.Processor == 3 && App.myComputer.VideoCard == 3 && App.myComputer.RamMemory == 3 && App.myComputer.SSD == 3 &&
                App.myComputer.Cooling == 3 && App.myComputer.Motherboard == 3 && App.myComputer.PowerSupply == 3 && App.myComputer.Body == 3)
            {
                App.myGamer.Fatigue -= 5;
            }
            else if (App.myComputer.Processor == 4 && App.myComputer.VideoCard == 4 && App.myComputer.RamMemory == 4 && App.myComputer.SSD == 4 &&
                App.myComputer.Cooling == 4 && App.myComputer.Motherboard == 4 && App.myComputer.PowerSupply == 4 && App.myComputer.Body == 4)
            {
                App.myGamer.Fatigue -= 10;
            }
            else if (App.myComputer.Processor == 5 && App.myComputer.VideoCard == 5 && App.myComputer.RamMemory == 5 && App.myComputer.SSD == 5 &&
                App.myComputer.Cooling == 5 && App.myComputer.Motherboard == 5 && App.myComputer.PowerSupply == 5 && App.myComputer.Body == 5)
            {
                App.myGamer.Fatigue -= 15;
            }
        }
    }
}
