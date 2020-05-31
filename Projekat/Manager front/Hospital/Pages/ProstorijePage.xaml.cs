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
    public partial class ProstorijePage : Page
    {
        public static ObservableCollection<RoomView> ListaSoba = new ObservableCollection<RoomView>();

        public ProstorijePage()
        {
            InitializeComponent();
            this.DataContext = this;
            
            if(ListaSoba.Count == 0)
            {
                for (var i = 0; i < 10; i++)
                    ListaSoba.Add(RandomData.GetRandomRoom());
            }

            dataGrid.ItemsSource = ListaSoba;
        }

        internal static void SetRenovation(uint id, DateTime selectedDate)
        {
            foreach (var room in ProstorijePage.ListaSoba)
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
    }
}
