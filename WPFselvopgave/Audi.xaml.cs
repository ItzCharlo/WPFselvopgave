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

namespace WPFselvopgave
{
    /// <summary>
    /// Interaction logic for Audi.xaml
    /// </summary>
    public partial class Audi : Window
    {
        public Audi()
        {
            InitializeComponent();
        }
        //Messagebox after buying a car
        private void A1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Audi Etron");

        }
        //Messagebox after buying a car
        private void A2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Audi R8");

        }
        //Messagebox after buying a car
        private void A3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Audi A6");

        }
        //Go back button. Returns you to main menu
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}
