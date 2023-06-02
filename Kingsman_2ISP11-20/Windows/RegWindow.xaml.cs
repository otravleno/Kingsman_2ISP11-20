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
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            CmbGender.ItemsSource = ClassHelper.EF.Context.Gender.ToList();
            CmbGender.DisplayMemberPath = "Name";
            CmbGender.SelectedIndex = 0;
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            //валидация
            if (string.IsNullOrEmpty(TbFirstName.Text))
            {
                MessageBox.Show("Поле Имя не заполнено");
                return;
            }
            if (string.IsNullOrEmpty(TbLastName.Text))
            {
                MessageBox.Show("Поле Фамиля не заполнено");
                return;
            }
            if (string.IsNullOrEmpty(TbLogin.Text))
            {
                MessageBox.Show("Поле Логин не заполнено");
                return;
            }
            if (string.IsNullOrEmpty(PbPassword.Password))
            {
                MessageBox.Show("Поле Пароль не заполнено");
                return;
            }
            if (string.IsNullOrEmpty(TbPhone.Text))
            {
                MessageBox.Show("Поле теелефон не заполнено");
                return;
            }
            //добавление
            DataBase.Client addClient = new DataBase.Client();
            addClient.Login = TbLogin.Text;
            addClient.Password = PbPassword.Password;
            addClient.FName = TbFirstName.Text;
            addClient.LName = TbLastName.Text;
            addClient.Phone = TbPhone.Text;
            addClient.Email = TbEmail.Text;
            addClient.IdGender = (CmbGender.SelectedItem as DataBase.Gender).Id;

            ClassHelper.EF.Context.Client.Add(addClient); 

            ClassHelper.EF.Context.SaveChanges();

            MessageBox.Show("Пользователь успешно добавлен");

        }
    }
}
