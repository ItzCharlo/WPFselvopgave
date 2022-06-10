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
    /// Interaction logic for Skoda.xaml
    /// </summary>
    public partial class Skoda : Window
    {
        public Skoda()
        {
            InitializeComponent();
        }
        //Messagebox after buying a car
        private void S1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Skoda Octavia");
        }
        //Messagebox after buying a car
        private void S2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Skoda Fabia");
        }
        //Messagebox after buying a car
        private void S3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Skoda Kodaq");
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
