using Hospital.ViewModel;
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
    /// Interaction logic for RoomProfilePage.xaml
    /// </summary>
    public partial class RoomProfilePage : Page
    {
        public static List<String> roomTypes = Enum.GetNames(typeof(RoomType)).ToList();

        public RoomProfilePage(RoomView room)
        {
            InitializeComponent();
            idLabel.Content = room.Id;
            roomComboBox.ItemsSource = Enum.GetNames(typeof(RoomType));
            if(room.RoomType != null) roomComboBox.SelectedItem = room.RoomType.ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            RoomView newRoom = null;
            foreach(var room in RoomPage.RoomList)
            {
                if(room.Id == Int32.Parse(idLabel.Content.ToString()))
                {
                    newRoom = room;
                    break;
                }
            }
            RoomPage.RoomList.Remove(newRoom);
            newRoom.RoomType = roomComboBox.SelectedItem.ToString();
            RoomPage.RoomList.Add(newRoom);

            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            NavigationService.Navigate(new Page());
        }

        private void deleteRoom(object sender, RoutedEventArgs e)
        {
            RoomView newRoom = null;
            foreach (var room in RoomPage.RoomList)
            {
                if (room.Id == Int32.Parse(idLabel.Content.ToString()))
                {
                    newRoom = room;
                    break;
                }
            }
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Da li ste sigurni da zelite da obrisete sobu?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                RoomPage.RoomList.Remove(newRoom);
                System.Windows.MessageBox.Show("Uspešno ste obrisali sobu.");
                NavigationService.Navigate(new Page());
            }

        }
    }
}
