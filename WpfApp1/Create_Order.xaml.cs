using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Create_Order.xaml
    /// </summary>
    public partial class Create_Order : Window
    {
        public static string linkBd = "Data Source=WIN-LK1QRPRQTC6\\SQLEXPRESS;Initial Catalog=Курсовая_2;Integrated Security=True";
        public Create_Order()
        {
           

        }

        private void Button_G_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_C_Click(object sender, RoutedEventArgs e)
        {
           Admin admin = new Admin();
            admin.Show();
            this.Close();

        }

        private void ComboboxSot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(linkBd))
            {
                connection.Open();

                string query = "Select ОписаниеПроблемы FROM ЗаявкиНаРемонт";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                         

                        }
                    }
                }
            }
        }
    }
}
