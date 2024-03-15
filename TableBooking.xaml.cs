using System;
using System.Collections.Generic;
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
using Lab1Kokoro.NIGHTCLUBDataSetTableAdapters;

namespace Lab1Kokoro
{
    /// <summary>
    /// Логика взаимодействия для TableBooking.xaml
    /// </summary>
    public partial class TableBooking : Window
    {
        TABLEBOOKINGTableAdapter table = new TABLEBOOKINGTableAdapter();
        public TableBooking()
        {
            InitializeComponent();
            TableData.ItemsSource = table.GetData();
            TableBoxName.ItemsSource = table.GetData();
            TableBoxName.DisplayMemberPath = "BOOKING_DATE"; 
        }

        private void TableBoxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Object tablename = (TableBoxName.SelectedItem as DataRowView).Row[4];
            MessageBox.Show(tablename.ToString());
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
