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
    /// Interaction logic for DrugPage.xaml
    /// </summary>
    public partial class DrugPage : Page
    {
        public static List<DrugView> drugList = new List<DrugView>();

        public DrugPage()
        {
            InitializeComponent();
            if(drugList.Count == 0)
            {
                for(var i = 0; i < 10; i++)
                {
                    drugList.Add(RandomData.GetRandomDrug());
                }
            }
            dataGrid.ItemsSource = drugList;
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var temp = new ObservableCollection<DrugView>(from x in drugList select (DrugView)x.Clone());
            var filteredList = new ObservableCollection<DrugView>();

            foreach (var zaposlen in temp)
            {
                if (zaposlen.Contains(searchBox.Text.ToUpper()))
                    filteredList.Add(zaposlen);
                dataGrid.ItemsSource = filteredList;
            }
        }
        private void Row_MouseDoubleClick_Drugs(object sender, MouseButtonEventArgs e)
        {
            var data = (DataGrid)sender;

            /*var openPage = new DrugProfilePage((DrugView)data.SelectedValue);
            Drugframe.Navigate(openPage);*/
        }

        private void addDrug_Click(object sender, RoutedEventArgs e)
        {
            var openPage = new AddDrug((int)DrugView.getIdCount());
            Drugframe.Navigate(openPage);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
