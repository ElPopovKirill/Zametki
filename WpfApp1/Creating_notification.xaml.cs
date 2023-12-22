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
    /// Логика взаимодействия для Creating_notification.xaml
    /// </summary>
    public partial class Creating_notification : Window
    {

        public Creating_notification()
        {
            InitializeComponent();
            LoadComboBoxValues();
            LoadComboBoxValues_2();
            LoadComboBoxValues_3();
            LoadComboBoxValues_4();
            DatePicker pi = new DatePicker();
            pi.Name = "datepicker";
            pi.DisplayDateStart = new DateTime(2023, 03, 02);
            pi.DisplayDateEnd = new DateTime(2023, 03, 20);
            pi.IsTodayHighlighted = true;
            stpanel1.Children.Add(pi);
           

        }

        private void Button_A_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Button_B_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }


        private void textBoxYD_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        

        private void ComboBoxST_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LoadComboBoxValues()
        {
            string connectionString = "Data Source=WIN-LK1QRPRQTC6\\SQLEXPRESS;Initial Catalog=Курсовая_2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Select Фио From Сотрудники";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                          

                        }
                    }
                }
            }
        }
        private void LoadComboBoxValues_2()
        {
            string connectionString = "Data Source=WIN-LK1QRPRQTC6\\SQLEXPRESS;Initial Catalog=Курсовая_2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Select Статус From Статус";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                        


                        }
                    }
                }
            }
        }
        private void LoadComboBoxValues_3()
        {
            string connectionString = "Data Source=WIN-LK1QRPRQTC6\\SQLEXPRESS;Initial Catalog=Курсовая_2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Select Содержание,+ Дедлайн,+ ID_Заказа From Заказы";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                         
                        }
                    }
                }
            }
        }
        private void LoadComboBoxValues_4()
        {
            string connectionString = "Data Source=WIN-LK1QRPRQTC6\\SQLEXPRESS;Initial Catalog=Курсовая_2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "Select ID_ТипаУведомления From ТипУведомлений";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                          
                        }
                    }
                }
            }
        }

        private void comboBox_3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
