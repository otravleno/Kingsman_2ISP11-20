using Kingsman_2ISP11_20.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Kingsman_2ISP11_20.ClassHelper;

namespace Kingsman_2ISP11_20.Windows
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();
            GetListService();
            
        }
        private void GetListService()
        {
           ObservableCollection<DataBase.Service> lastCart = new ObservableCollection<DataBase.Service>(ClassHelper.CartServiceClass.ServiceCart);
            LvCartService.ItemsSource = lastCart.Distinct();
            
        }
        
        
        private void BtnRomoveToCart_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            var service = button.DataContext as DataBase.Service;
            ClassHelper.CartServiceClass.ServiceCart.Remove(service);

            GetListService();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ServiceWindow serviceWindow = new ServiceWindow();
            serviceWindow.Show();
            this.Close();
        }

        private void BtnPyu_Click(object sender, RoutedEventArgs e)
        {
            //оформление заказа
            DataBase.Order order = new DataBase.Order();
            order.IdClient = 2;
            order.IdEmployee = 1;
            
            EF.Context.Order.Add(order);
            
            EF.Context.SaveChanges();
            foreach (var item in ClassHelper.CartServiceClass.ServiceCart)
            {
                DataBase.OrderService orderService = new DataBase.OrderService();
                orderService.IdOrder = 3;
                orderService.IdService = item.Id;
                orderService.Quantity = item.Count;

                EF.Context.OrderService.Add(orderService);
                EF.Context.SaveChanges();

            }
            EF.Context.SaveChanges();

            MessageBox.Show("Заказ оформлен");
            ClassHelper.CartServiceClass.ServiceCart.Clear();
            ServiceWindow serviceWindow2 = new ServiceWindow();
            serviceWindow2.Show();
            this.Close();
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            var service = button.DataContext as DataBase.Service;

            service.Count--;
        }

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            var service = button.DataContext as DataBase.Service;

            service.Count++;
        }

        
    }
}
