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
    /// Interaction logic for Toyota.xaml
    /// </summary>
    public partial class Toyota : Window
    {
        public Toyota()
        {
            InitializeComponent();
        }

        private void T1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Toyota Corolla GR");
        }
        private void T2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Toyota RAV4");

        }
        private void T3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Du har købt: Toyota Supra MK5");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

    }
}
