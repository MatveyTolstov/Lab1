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
    /// Логика взаимодействия для EventWindow.xaml
    /// </summary>
    public partial class EventWindow : Window
    {
        EVENTS_CLIENTSTableAdapter events = new EVENTS_CLIENTSTableAdapter();
        public EventWindow()
        {
            InitializeComponent();
            EventsData.ItemsSource = events.GetData();
            EventBoxName.ItemsSource = events.GetData();
            EventBoxName.DisplayMemberPath = "EVENT_NAME";
        }

        private void EventBoxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Object eventname = (EventBoxName.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(eventname.ToString());
        }
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
