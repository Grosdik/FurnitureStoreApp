using CalculationsLibrary;
using System;
using System.Windows;
using System.Windows.Controls;

namespace FurnitureStoreApp.Views.CalculationPage
{
    /// <summary>
    /// Логика взаимодействия для CalculationCreditPage.xaml
    /// </summary>
    public partial class CalculationCreditPage : Page
    {
        public CalculationCreditPage()
        {
            InitializeComponent();
        }

        private void btnCalculation_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if((loanAmount.Text != "") && (loanTerm.Text != ""))
            {
                double S = Convert.ToDouble(loanAmount.Text);
                double N = Convert.ToDouble(loanTerm.Text);

                double action = Calculations.CalculatingTheCredits(S, N);

                MessageBox.Show("Ежемесечная выплата составит: "+ action +"!", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
