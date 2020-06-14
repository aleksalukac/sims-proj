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
            var rm = new RoomPage();
            roomsComboBox.ItemsSource = RoomPage.RoomList;

            foreach(var room in RoomPage.RoomList)
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
            if(nameTextBox.Text.Length == 0)
            {
                //ResourcePage.SupplyList.Remove(newSupply);
                //newSupply.Type = nameTextBox.Text;
                System.Windows.MessageBox.Show("Unesite pravilno ime materijala.");
                //NavigationService.Navigate(new Page());
                return;
            }
            var s = roomsComboBox.SelectedItem as RoomView;

            ResourcePage.ResourceList.Remove(newResource);

            newResource.RoomId = (int)s.Id;
            newResource.Type = nameTextBox.Text;

            ResourcePage.ResourceList.Add(newResource);

            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            NavigationService.Navigate(new Page());
        }

        private void roomsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void delete(object sender, RoutedEventArgs e)
        {
            ResourceView newResource = null;
            foreach (var resource in ResourcePage.ResourceList)
            {
                if (resource.Id == Int32.Parse(idLabel.Content.ToString()))
                {
                    newResource = resource;
                    break;
                }
            }

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Da li ste sigurni da zelite da izbrišete ovaj resurs?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ResourcePage.ResourceList.Remove(newResource);
                System.Windows.MessageBox.Show("Promene uspešno sačuvane");
                NavigationService.Navigate(new Page());
                return;
            }
        }
    }
}
