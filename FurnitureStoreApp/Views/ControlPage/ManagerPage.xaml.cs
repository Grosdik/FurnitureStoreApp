using FurnitureStoreApp.Utils;
using FurnitureStoreApp.Views.CalculationPage;
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

namespace FurnitureStoreApp.Views.ControlPage
{
    /// <summary>
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void btnCalculatingCredit_Click(object sender, RoutedEventArgs e)
        {
            Transfer.MainFrame.Navigate(new CalculationCreditPage());
        }
    }
}
