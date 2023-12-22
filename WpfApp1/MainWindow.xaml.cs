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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass =  passBox.Password.Trim();

            if (login == "1" ) {

                Employee employee = new Employee();
                employee.Show();
                this.Close();
            }
                          
            else {
                textBoxLogin.ToolTip = "Логин верный";
                textBoxLogin.Background = Brushes.Green;
                passBox.ToolTip = "Пароль не правильный";
                passBox.Background = Brushes.Green;

                MessageBox.Show("Вы прошли авторизацию");

                Admin admin = new Admin();
                admin.Show();
                this.Close();

            }
        }

        private void Button_Chrehlick(object sender, RoutedEventArgs e)
        {
            Order_Change_window order_Change_Window = new Order_Change_window();
            order_Change_Window.Show();
          
        }

        private void Button_Cldsfick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("У дедлайна не может быть прошедшей даты");
           
        }
    }
}
