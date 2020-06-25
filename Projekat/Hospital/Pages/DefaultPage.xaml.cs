using Hospital.Windows;
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

namespace Hospital.Pages
{
    /// <summary>
    /// Interaction logic for DefaultPage.xaml
    /// </summary>
    public partial class DefaultPage : Page
    {
        public DefaultPage()
        {
            InitializeComponent();
            var page1 = new RoomPage();
            var page2 = new DrugPage();
            var page3 = new ResourcePage();
            var page4 = new EmployeesPage();
            //profileFrame.Navigate(new UserAccount());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nextWindow = new MainWindow();
            nextWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var nextPage = new DrugPage();
            frame.Navigate(nextPage);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var nextPage = new EmployeesPage();
            frame.Navigate(nextPage);
        }

        private void Button_Click_Prostorije(object sender, RoutedEventArgs e)
        {
            var nextPage = new RoomPage();
            frame.Navigate(nextPage);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var nextWindow = new ProblemReportWindow();
            nextWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new UserAccount());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var nextPage = new ResourcePage();
            frame.Navigate(nextPage);
        }
    }
}
