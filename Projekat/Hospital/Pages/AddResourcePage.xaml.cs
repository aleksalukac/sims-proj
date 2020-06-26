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
    /// Interaction logic for AddResourcePage.xaml
    /// </summary>
    public partial class AddResourcePage : Page
    {
        public AddResourcePage()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            //NavigationService.Navigate(new Page());
        }

        private void roomsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
