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
    /// Interaction logic for ProstorijePage.xaml
    /// </summary>
    public partial class RoomPage : Page
    {
        public static ObservableCollection<RoomView> RoomList = new ObservableCollection<RoomView>();

        public RoomPage()
        {
            InitializeComponent();
            this.DataContext = this;
            
            if(RoomList.Count == 0)
            {
                for (var i = 0; i < 10; i++)
                    RoomList.Add(RandomData.GetRandomRoom());
            }

            dataGrid.ItemsSource = RoomList;
        }

        internal static void SetRenovation(uint id, DateTime selectedDate)
        {
            foreach (var room in RoomPage.RoomList)
            {
                if (room.Id == id)
                {
                    room.Renovation = selectedDate;
                    break;
                }
            }
            //dataGrid.ItemsSource = ListaSoba;
        }

        private void Row_MouseDoubleClick_Prostorije(object sender, MouseButtonEventArgs e)
        {
            var data = (DataGrid)sender;

            var OpenPage = new RenoviranjePage((Model.RoomView)data.SelectedValue);
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
                var OpenPage = new RenoviranjePage((Model.RoomView)dataGrid.SelectedItem);
                frame.Navigate(OpenPage);
            }
        }

        private void urediSobu(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedItem != null)
                frame.Navigate(new RoomProfilePage((RoomView)dataGrid.SelectedItem));
        }

        private void dodajSobu(object sender, RoutedEventArgs e)
        {
            var newRoom = new RoomView();
            RoomPage.RoomList.Add(newRoom);
            frame.Navigate(new RoomProfilePage(newRoom));
        }
    }
}
