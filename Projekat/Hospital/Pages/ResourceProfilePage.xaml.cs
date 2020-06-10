using Hospital.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ResourceProfilePage.xaml
    /// </summary>
    public partial class ResourceProfilePage : Page
    {
        public ResourceProfilePage(ResourceView resource)
        {
            InitializeComponent();

            nameTextBox.Text = resource.Type;
            idLabel.Content = resource.Id;
            var rm = new ProstorijePage();
            roomsComboBox.ItemsSource = ProstorijePage.RoomList;

            foreach(var room in ProstorijePage.RoomList)
            {
                if(room.Id == resource.RoomId)
                {
                    roomsComboBox.SelectedItem = room;
                }
            }

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            ResourceView newResource = null;
            foreach(var resource in ResourcePage.ResourceList)
            {
                if(resource.Id == Int32.Parse(idLabel.Content.ToString()))
                {
                    newResource = resource;
                    break;
                }
            }
            var s = roomsComboBox.SelectedItem as RoomView;
            newResource.RoomId = (int)s.Id;
            newResource.Type = nameTextBox.Text;
            var page = new Page();
            NavigationService.Navigate(page);
        }

        private void roomsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
