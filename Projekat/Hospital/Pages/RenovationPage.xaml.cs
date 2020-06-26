using Controllers;
using Hospital.ViewModel;
using Model;
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
    public partial class RenovationPage : Page
    {
        private List<string> roomTypes = Enum.GetNames(typeof(RenovationType)).ToList();
        private RoomController _roomController;

        public RenovationPage(RoomView room)
        {
            _roomController = (Application.Current as App).RoomController;
            InitializeComponent();
            idLabel.Content = room.Id;
            renovationTypeComboBox.ItemsSource = roomTypes;

            List<RoomView> roomsToMerge = new List<RoomView>();
            foreach (var _room in RoomPage.RoomList)
                if (_room.Id != room.Id && _room.RoomType.Equals(room.RoomType))
                    roomsToMerge.Add(_room);

            roomComboBox.ItemsSource = roomsToMerge;

            roomLabel.Visibility = Visibility.Hidden;
            roomComboBox.Visibility = Visibility.Hidden;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(calendar.SelectedDate == null)
            {
                System.Windows.MessageBox.Show("Unesite datum renoviranja.");
                return;
            }

            DateTime renovationDateTime = (DateTime)calendar.SelectedDate;
            //RoomPage.SetRenovation((uint)idLabel.Content, (DateTime)calendar.SelectedDate);
            int roomLabel = Int32.Parse(idLabel.Content.ToString());

            if (renovationDateTime < DateTime.Now)
            {
                System.Windows.MessageBox.Show("Unesite dobar datum renoviranja.");
                return;
            }

            if(renovationTypeComboBox.SelectedItem.Equals("mergeRooms"))
            {
                if(roomComboBox.SelectedItem == null)
                {
                    System.Windows.MessageBox.Show("Unesite sobu sa kojom spajate.");
                    return;
                }

                RoomView roomToDelete = (RoomView)roomComboBox.SelectedItem;


                if (_roomController.CanRenovate(roomLabel, renovationDateTime) && _roomController.CanRenovate((int)roomToDelete.Id, renovationDateTime))
                {
                    var mergedRoom = _roomController.Merge(roomLabel, (int)roomToDelete.Id);

                    if (mergedRoom == null)
                    {
                        System.Windows.MessageBox.Show("Spajanje nije moguce");
                        return;
                    }

                    RoomPage.DeleteRoom(roomToDelete.Id);
                }
                else
                {
                    System.Windows.MessageBox.Show("Renoviranje nije dozvoljeno");
                    return;
                }
            }
            else 
            {
                if(_roomController.CanRenovate(roomLabel, renovationDateTime))
                {
                    if (renovationTypeComboBox.SelectedItem.Equals("splitRoom"))
                    {
                        Room oldRoom = _roomController.Get(roomLabel);
                        Room newRoom = new Room();
                        newRoom.RoomType = oldRoom.RoomType;
                        _roomController.Add(newRoom);

                        RoomPage.RoomList.Add(new RoomView(newRoom, _roomController));
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Renoviranje nije dozvoljeno");
                    return;
                }
            }


            Renovation renovation = new Renovation();
            renovation.Date = renovationDateTime;
            renovation.RenovationType = (RenovationType)renovationTypeComboBox.SelectedIndex;
            _roomController.AddRenovation(renovation);

            Room room = _roomController.Get(roomLabel);
            room.Renovation.Add(renovation.Id);
            _roomController.Update(room);
            RoomPage.SetRenovation((uint)idLabel.Content, (DateTime)calendar.SelectedDate);

            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            NavigationService.Navigate(new Page());
        }

        private void renovationTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (renovationTypeComboBox.SelectedItem.Equals("mergeRooms"))
            {
                roomComboBox.Visibility = Visibility.Visible;
                roomLabel.Visibility = Visibility.Visible;
            }
            else
            {
                roomComboBox.Visibility = Visibility.Hidden;
                roomLabel.Visibility = Visibility.Hidden;
            }
        }
    }
}
