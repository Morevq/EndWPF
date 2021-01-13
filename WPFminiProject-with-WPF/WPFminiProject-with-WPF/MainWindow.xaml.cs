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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPFminiProject_with_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int a;
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_tick;
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();                   //Создание объекта для генерации чисел
                int a = Convert.ToInt32(tb1.Text);           //Числа для диапазона
                int b = Convert.ToInt32(tb2.Text);
                if (a > b)
                {
                    int x = a;
                    a = b;
                    b = x;
                }
                b += 1;                                      //чтоба как и а, b тоже входило в диапазон
                int value = rnd.Next(a, b);                  //Получить случайное число (в диапазоне от a до b)
                tb3.Text = Convert.ToString(value);
            }
            catch
            {
                tb3.Text = "Error";
            }
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(sym.Text); //Длинна пароля
                if (c1.IsChecked == true && c2.IsChecked == false && c3.IsChecked == false && c4.IsChecked == false && c5.IsChecked == false && n >= 0)
                {
                    char[] arr = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                    Random rnd = new Random();                   //Создание объекта для генерации чисел
                    int value = rnd.Next(0, 26);                 //Получить случайное число (в диапазоне от 0 до 10), не включая 10
                    string s = "";                               //Переменная для пароля из чисел
                    for (int i = 0; i < n; ++i)                  //Цикл для создания всего пароля
                    {
                        s += arr[value];
                        value = rnd.Next(0, 26);
                    }
                    sym1.Text = Convert.ToString(s);
                }
                else if (c1.IsChecked == false && c2.IsChecked == true && c3.IsChecked == false && c4.IsChecked == false && c5.IsChecked == false && n >= 0)
                {
                    char[] arr = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                    Random rnd = new Random();                   //Создание объекта для генерации чисел
                    int value = rnd.Next(0, 26);                 //Получить случайное число (в диапазоне от 0 до 10), не включая 10
                    string s = "";                               //Переменная для пароля из чисел
                    for (int i = 0; i < n; ++i)                  //Цикл для создания всего пароля
                    {
                        s += arr[value];
                        value = rnd.Next(0, 26);
                    }
                    sym1.Text = Convert.ToString(s);
                }
                else if (c1.IsChecked == false && c2.IsChecked == false && c3.IsChecked == true && c4.IsChecked == false && c5.IsChecked == false && n >= 0)
                {
                    char[] arr = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                    Random rnd = new Random();                   //Создание объекта для генерации чисел
                    int value = rnd.Next(0, 52);                 //Получить случайное число (в диапазоне от 0 до 10), не включая 10
                    string s = "";                               //Переменная для пароля из чисел
                    for (int i = 0; i < n; ++i)                  //Цикл для создания всего пароля
                    {
                        s += arr[value];
                        value = rnd.Next(0, 52);
                    }
                    sym1.Text = Convert.ToString(s);
                }
                else if (c1.IsChecked == false && c2.IsChecked == false && c3.IsChecked == false && c4.IsChecked == true && c5.IsChecked == false && n >= 0)
                {
                    Random rnd = new Random();                   //Создание объекта для генерации чисел
                    int value = rnd.Next(0, 10);                 //Получить случайное число (в диапазоне от 0 до 10), не включая 10
                    string s = "";                               //Переменная для пароля из чисел
                    for (int i = 0; i < n; ++i)                  //Цикл для создания всего пароля
                    {
                        s += value;
                        value = rnd.Next(0, 10);
                    }
                    sym1.Text = Convert.ToString(s);
                }
                else if (c1.IsChecked == false && c2.IsChecked == false && c3.IsChecked == false && c4.IsChecked == false && c5.IsChecked == true && n >= 0)
                {
                    char[] arr = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    Random rnd = new Random();                   //Создание объекта для генерации чисел
                    int value = rnd.Next(0, 72);                 //Получить случайное число (в диапазоне от 0 до 10), не включая 10
                    string s = "";                               //Переменная для пароля из чисел
                    for (int i = 0; i < n; ++i)                  //Цикл для создания всего пароля
                    {
                        s += arr[value];
                        value = rnd.Next(0, 72);
                    }
                    sym1.Text = Convert.ToString(s);
                }
                else
                {
                    sym1.Text = "Error";
                }
            }
            catch
            {
                sym1.Text = "Error";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Six.IsEnabled = false;
            a = 15;
            char[] arr = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Random rnd = new Random();                   //Создание объекта для генерации чисел
            int value = rnd.Next(0, 72);                 //Получить случайное число (в диапазоне от 0 до 10), не включая 10
            string s = "";                               //Переменная для пароля из чисел
            for (int i = 0; i < 6; ++i)                  //Цикл для создания всего пароля
            {
                s += arr[value];
                value = rnd.Next(0, 72);
            }
            tbl.Text = Convert.ToString(s);
            timer.Start();
        }
        private void timer_tick(object sender, EventArgs e)
        {
            if (pb.Value == 0)
            {
                Storyboard board = (Storyboard)Resources["Anim"];
                board.Begin();
            }
            a -= 1;
            if (a == -1)
            {
                tbl1.Text = "До обновления осталось 15 секунд";
            }
            else
            {
                tbl1.Text = "До обновления осталось " + Convert.ToString(a) + " секунд";
            }
            //pb.Value += 1;
            if (pb.Value > 10)
            {
                pb.Foreground = Brushes.Red;
            }
            else
            {
                pb.Foreground = Brushes.Green;
            }
            if (a == -1)
            {
                a = 15;
                timer.Start();
                pb.Value = 0;
                char[] arr = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                Random rnd = new Random();                   //Создание объекта для генерации чисел
                int value = rnd.Next(0, 72);                 //Получить случайное число (в диапазоне от 0 до 10), не включая 10
                string s = "";                               //Переменная для пароля из чисел
                for (int i = 0; i < 6; ++i)                  //Цикл для создания всего пароля
                {
                    s += arr[value];
                    value = rnd.Next(0, 72);
                }
                tbl.Text = Convert.ToString(s);
            }
        }
    }
}
