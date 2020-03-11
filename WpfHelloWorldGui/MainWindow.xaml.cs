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

namespace WpfHelloWorldGui
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

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Someone clicked the register button");
            Console.WriteLine("User name = " + nickname.Text);

            int userAge = Convert.ToInt32(age.Text);

            log.Text = "Name = " + nickname.Text;
            log.AppendText("\nAge of user is " + userAge);
            log.AppendText("\nGender of user is " + gender.Text);

        }

        private void Color_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected = (ComboBoxItem)color.SelectedItem;
            if (selected.Content.ToString() == "Pink")
            {
                log.Background = Brushes.Pink;
            } else if (selected.Content.ToString() == "Aqua")
            {
                log.Background = Brushes.Aqua;
            }
        }

        private void SwitchToSecondWindow_Click(object sender, RoutedEventArgs e)
        {
            // Pass the name of the user via constructor
            SecondWindow secondWindow = new SecondWindow(nickname.Text);

            // Or via setter
            //secondWindow.SetName("Nico");       // Works too

            // Dont
            //secondWindow.username.Text = "Nico";        // DONT DO THIS !!!!!!!

            // Show second window and close current
            secondWindow.Show();
            this.Close();
        }
    }
}
