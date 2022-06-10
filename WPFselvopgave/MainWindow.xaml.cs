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

namespace WPFselvopgave
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string choice1 = "TOYOTA";
            string userInput = BilMærkeText.Text.ToString();
            string choice2 = "AUDI";
            string choice3 = "SKODA";

            if (userInput == choice1)
            {
                Toyota win2 = new Toyota();
                win2.Show();
                this.Close();
            }
            else if (userInput == choice2)
            {
                Audi win3 = new Audi();
                win3.Show();
                this.Close();
            }
            else if (userInput == choice3)
            {
                Skoda win4 = new Skoda();
                win4.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Den du ledder efter findes ikke");
            }

        }
    }
    
}

