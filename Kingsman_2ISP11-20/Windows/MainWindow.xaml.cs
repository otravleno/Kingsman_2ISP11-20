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

namespace Kingsman_2ISP11_20.Windows
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

        private void BtnService_Click(object sender, RoutedEventArgs e)
        {
            ServiceWindow serviceWindow = new ServiceWindow();
            serviceWindow.Show();
            this.Close();
        }

        private void BtnEmployees_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSurprize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSurprize_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
