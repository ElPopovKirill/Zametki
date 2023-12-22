using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        public static string linkBd = "Data Source=WIN-LK1QRPRQTC6\\SQLEXPRESS;Initial Catalog=Курсовая_2;Integrated Security=True";
        public Employee()
        {
            InitializeComponent();
            SqlConnection str = new SqlConnection(linkBd);
            str.Open();
            string query = "select * from Заметки";
            SqlCommand createCommand = new SqlCommand(query, str);
            createCommand.ExecuteNonQuery();
            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Grid");
            dataAdp.Fill(dt);
            Grid_1.ItemsSource = dt.DefaultView;
            str.Close();
        }

        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_R_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_P_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection str = new SqlConnection(linkBd);
            str.Open();
            string query = "select ТипУведомлений.Тип,Сотрудники.Фио,Статус.Статус,ДатаиВремя,Заказы.Содержание from Уведомление join ТипУведомлений on ТипУведомлений.ID_ТипаУведомления = Уведомление.ID_ТипУведомления join Сотрудники on Сотрудники.ID_Сотрудника = Уведомление.ID_Уведмоление join Заказы on Заказы.ID_Заказа = Уведомление.ID_Заказа join Статус on Статус.ID_Статуса = Уведомление.ID_Статуса";
            SqlCommand createCommand = new SqlCommand(query, str);
            createCommand.ExecuteNonQuery();
            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Grid_1");
            dataAdp.Fill(dt);
            Grid_1.ItemsSource = dt.DefaultView;
            str.Close();
        }
    }
}
