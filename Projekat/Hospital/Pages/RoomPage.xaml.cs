using Controllers;
using Hospital.ViewModel;
using Model;
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
    /// Interaction logic for ProstorijePage.xaml
    /// </summary>
    public partial class RoomPage : Page
    {
        private RoomController _roomController;

        public static ObservableCollection<RoomView> RoomList = new ObservableCollection<RoomView>();

        public RoomPage()
        {
            _roomController = (Application.Current as App).RoomController;

            InitializeComponent();
            this.DataContext = this;
            
            if(RoomList.Count == 0)
            {
                List<Room> rooms = _roomController.GetAll();

                for (var i = 0; i < rooms.Count; i++)
                {
                    RoomList.Add(new RoomView(rooms[i], _roomController));
                }
            }

            dataGrid.ItemsSource = RoomList;
        }

        public static void DeleteRoom(uint id)
        {
            foreach (var room in RoomPage.RoomList)
            {
                if (room.Id == id)
                {
                    RoomList.Remove(room);
                    break;
                }
            }
        }

        internal static void SetRenovation(uint id, DateTime selectedDate)
        {
            foreach (var room in RoomPage.RoomList)
            {
                if (room.Id == id)
                {
                    RoomList.Remove(room);
                    room.Renovation = selectedDate;
                    RoomList.Add(room);
                    break;
                }
            }
            //dataGrid.ItemsSource = ListaSoba;
        }

        public static int GetRoomCount(string type)
        {
            int count = 0;
            foreach(var room in RoomList)
            {
                if (room.RoomType.Equals(type))
                    count++;
            }

            return count;
        }

        private void Row_MouseDoubleClick_Prostorije(object sender, MouseButtonEventArgs e)
        {
            var data = (DataGrid)sender;

            var OpenPage = new RenovationPage((ViewModel.RoomView)data.SelectedValue);
            frame.Navigate(OpenPage);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ReportPage());
        }

        private void renoviranjeClick(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedItem != null)
            {
                var OpenPage = new RenovationPage((ViewModel.RoomView)dataGrid.SelectedItem);
                frame.Navigate(OpenPage);
            }
        }

        private void urediSobu(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                var openPage = new RoomProfilePage((RoomView)dataGrid.SelectedItem);
                frame.Navigate(openPage);
            }
        }

        private void dodajSobu(object sender, RoutedEventArgs e)
        {
            var newRoom = new RoomView();
            //RoomPage.RoomList.Add(newRoom);
            frame.Navigate(new RoomProfilePage(newRoom, true));
        }

        private void pogledajGrafikon(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new RoomChartPage());
        }
    }
}
