using FurnitureStoreApp.Database;
using FurnitureStoreApp.Utils;
using FurnitureStoreApp.Views.ControlPage;
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

namespace FurnitureStoreApp.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        private int _userId;
        private int _userRoleId;
        private string _userLogin;
        private string _userPass;
        public AuthorizationPage()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((txtLogin.Text != "") && (txtPassword.Password != ""))
                {
                    string loginQuery = "SELECT * FROM Users WHERE Login = '" + txtLogin.Text + "'";
                    var str = Furniture_storeEntities.GetContext().Users.SqlQuery(loginQuery).ToList();
                    var row = str[0];
                    _userId = row.Id;
                    _userRoleId = row.RoleId;
                    _userLogin = row.Login;
                    _userPass = row.Password;
                    if ((_userRoleId == 1) && (_userPass == txtPassword.Password))
                    {
                        MessageBox.Show("Вы успешно авторизированы!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                        Transfer.MainFrame.Navigate(new AdminPage());
                        DateTime dt = DateTime.Now;
                        AuthHistory history = new AuthHistory();
                        return;
                    }
                    else if ((_userRoleId == 2) && (_userPass == txtPassword.Password))
                    {
                        MessageBox.Show("Вы успешно авторизированы!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                        Transfer.MainFrame.Navigate(new ManagerPage());
                        return;
                    }
                    else
                    {
                        if (_userLogin != "")
                        {

                        }
                        MessageBox.Show("Неверный логин или пароль!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else if ((txtLogin.Text == "") && (txtPassword.Password != ""))
                {
                    MessageBox.Show("Не заполнено поле логина!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if ((txtLogin.Text != "") && (txtPassword.Password == ""))
                {
                    MessageBox.Show("Не заполнено поле пароля!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if ((txtLogin.Text == "") && (txtPassword.Password == ""))
                {
                    MessageBox.Show("Не заполнено поле логина и пароля!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Отсутсвует связь с базой данных!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
