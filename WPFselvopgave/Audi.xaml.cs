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

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Audi Etron");

        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Audi R8");

        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Audi A6");

        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}
