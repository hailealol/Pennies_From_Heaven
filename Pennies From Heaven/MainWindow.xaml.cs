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

namespace Pennies_From_Heaven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pennies = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(inputPennies.Text, out pennies);

            int dollar = pennies / 100;
            outDollar.Text = dollar.ToString();
            pennies = pennies % 100;
            int quarters = pennies / 25;
            outQuarter.Text = quarters.ToString();
            pennies = pennies % 25;
            int dimes = pennies / 10;
            outDime.Text = dimes.ToString();
            pennies = pennies % 10;
            int nickels = pennies / 5;
            outNickel.Text = nickels.ToString();
            pennies = pennies % 5;
            int penny = pennies / 1;
            outPenny.Text = penny.ToString();
        }
    }
}
