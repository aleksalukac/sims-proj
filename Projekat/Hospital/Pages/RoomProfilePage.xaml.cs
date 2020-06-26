using Controllers;
using Hospital.ViewModel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static List<String> roomTypes = Enum.GetNames(typeof(Model.RoomType)).ToList();

        private RoomController _roomController;

        private bool isNewRoom = false;

        public RoomProfilePage(RoomView room, bool isPrivate = false)
        {
            isNewRoom = isPrivate;
            _roomController = (Application.Current as App).RoomController;

            InitializeComponent();
            if (!isNewRoom)
                idLabel.Content = room.Id;

            var maxNumberOfPatients = _roomController.Get((int)room.Id);
            if (maxNumberOfPatients == null)
                textBox.Text = "20";
            else
                textBox.Text = _roomController.Get((int)room.Id).MaxNumberOfPatients.ToString();


            roomComboBox.ItemsSource = Enum.GetNames(typeof(Model.RoomType));
            if(room.RoomType != null) roomComboBox.SelectedItem = room.RoomType.ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            RoomView newRoom = new RoomView();
            Room room = new Room();

            if (!isNewRoom)
                foreach (var _room in RoomPage.RoomList)
                {
                    if(_room.Id == Int32.Parse(idLabel.Content.ToString()))
                    {
                        newRoom = _room;
                        break;
                    }
                }
            else
                newRoom.Id = (uint)room.Id;

            if (!isNewRoom)
                RoomPage.RoomList.Remove(newRoom);
            newRoom.RoomType = roomComboBox.SelectedItem.ToString();

            room = newRoom.Convert();

            int newMaxNumberOfPatients = Int32.Parse(textBox.Text);

            if(newMaxNumberOfPatients < room.Patient.Count)
            {
                newMaxNumberOfPatients = room.Patient.Count;
            }

            room.MaxNumberOfPatients = newMaxNumberOfPatients;
            room.Id = (int)newRoom.Id;

            if (!isNewRoom)
            {
                _roomController.Update(room);
            }
            else
            {
                _roomController.Add(room);
            }

            RoomPage.RoomList.Add(newRoom);

            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            NavigationService.Navigate(new Page());
        }

        private void deleteRoom(object sender, RoutedEventArgs e)
        {
            if(isNewRoom)
            {
                NavigationService.Navigate(new Page());
                return;
            }

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
                if(newRoom != null)
                {
                    RoomPage.RoomList.Remove(newRoom);
                    _roomController.Remove((int)newRoom.Id);
                }
                System.Windows.MessageBox.Show("Uspešno ste obrisali sobu.");
                NavigationService.Navigate(new Page());
            }

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox.Text = Regex.Replace(textBox.Text, @"[^\d]", "");
        }
    }
}
