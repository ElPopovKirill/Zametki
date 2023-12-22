using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public static string linkBd = "Data Source=WIN-LK1QRPRQTC6\\SQLEXPRESS;Initial Catalog=Курсовая_2;Integrated Security=True";
        public Admin()
        {
            InitializeComponent();
            SqlConnection str = new SqlConnection(linkBd);
            str.Open();
            string query = "select Категория.Категория,Уведомление.ID_Заказа,ДатаСоздания,ПлановаяДата,Описание from Заметки join Категория on Категория.ID_Категория = Заметки.ID_Заметки join Уведомление on Уведомление.ID_Заказа = Заметки.ID_Заметки";
            SqlCommand  createCommand = new SqlCommand(query,str);
            createCommand.ExecuteNonQuery();
            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt= new DataTable("Grid");
            dataAdp.Fill(dt);
            Grid.ItemsSource = dt.DefaultView;
            str.Close();
        }

        private void Button_R_Click(object sender, RoutedEventArgs e)
        {
            Create_Order create_Order = new Create_Order();
            create_Order.Show();
            this.Close();
        }

        private void Button_P_Click(object sender, RoutedEventArgs e)
        {
            Change_Notification_window change_Notification_Window = new Change_Notification_window();
            change_Notification_Window.Show();
            this.Close();
        }

        private void DataGrid_Drop(object sender, DragEventArgs e)
        {

        }

        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
