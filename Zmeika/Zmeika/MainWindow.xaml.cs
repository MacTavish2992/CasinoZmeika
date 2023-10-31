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

namespace Zmeika
{

    public class Game
    {
        public int balance = 500;

    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            balanc.Text = Convert.ToString(game.balance);
            
        }
        Game game = new Game();
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (game.balance <= 0)
            {
                MessageBox.Show("Ваш баланс пуст, начните новую игру!");

            }
            else
            {
                if(Convert.ToInt32(stavka.Text)>game.balance)
                {
                    MessageBox.Show("Ставка не приянта, Ваш баланс меньше!");
                }
                else
                {
                    int numb = Convert.ToInt32(number.Text);
                    Random rnd = new Random();
                    int koef = rnd.Next(2, 6); 
                    kof.Text = Convert.ToString("Коэффициент: " + koef);
                    int a = rnd.Next(1, 11);
                    int b = Convert.ToInt32(stavka.Text);
                    if (a == numb)
                    {
                        balanc.Text = Convert.ToString("Баланс: " + game.balance);
                        result.Text = "Выигрыш!";
                        game.balance = game.balance + b * koef;

                    }
                    else
                    {
                        balanc.Text = Convert.ToString("Баланс: " + game.balance);
                        result.Text = "Вы проиграли!";
                        game.balance = game.balance - b;
                    }

                    balanc.Text = Convert.ToString("Баланс: " + game.balance);
                    ra.Text = Convert.ToString("Выпало: " + a);
                }
                
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            game.balance = 500;
            balanc.Text = Convert.ToString("Баланс: " + game.balance);
        }
    }
}
