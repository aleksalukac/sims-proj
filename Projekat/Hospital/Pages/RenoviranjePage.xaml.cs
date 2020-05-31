using Hospital.Model;
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
    /// Interaction logic for RenoviranjePage.xaml
    /// </summary>
    public partial class RenoviranjePage : Page
    {
        public RenoviranjePage(RoomView room)
        {
            InitializeComponent();
            idLabel.Content = room.Id;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ProstorijePage.SetRenovation((uint)idLabel.Content, (DateTime)calendar.SelectedDate);
           
            
            var page = new Page();
            NavigationService.Navigate(page);
        }
    }
}
