using Hospital.Model;
using Hospital.Windows;
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
    /// Interaction logic for ResourcePage.xaml
    /// </summary>
    public partial class ResourcePage : Page
    {
        public static ObservableCollection<ResourceView> ResourceList = new ObservableCollection<ResourceView>();
        public static ObservableCollection<SupplyView> SupplyList = new ObservableCollection<SupplyView>();

        public ResourcePage()
        {
            InitializeComponent();

            if(ResourceList.Count == 0)
            {
                for(var i = 0; i <= 10; i++)
                {
                    ResourceList.Add(RandomData.GetRandomResource());
                }
            }

            if (SupplyList.Count == 0)
            {
                for (var i = 0; i < 4; i++)
                {
                    SupplyList.Add(RandomData.GetRandomSupply());
                }
            }

            resourceDataGrid.ItemsSource = ResourceList;
            supplyDataGrid.ItemsSource = SupplyList;

        }

        private void addSupply_Click(object sender, RoutedEventArgs e)
        {
            //var data = (DataGrid)sender;

            SupplyView supply = new SupplyView();
            SupplyList.Add(supply);

            var openPage = new SupplyProfilePage(supply);
            frame.Navigate(openPage);
        }

        private void addResource_Click(object sender, RoutedEventArgs e)
        {
            //var data = (DataGrid)sender;

            ResourceView resource = new ResourceView();
            ResourceList.Add(resource);

            var openPage = new ResourceProfilePage(resource);
            frame.Navigate(openPage);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Row_MouseDoubleClick_Supply(object sender, MouseButtonEventArgs e)
        {
            var data = (DataGrid)sender;

            var openPage = new SupplyProfilePage((SupplyView)data.SelectedValue);
            frame.Navigate(openPage);
        }

        private void Row_MouseDoubleClick_Resource(object sender, MouseButtonEventArgs e)
        {
            var data = (DataGrid)sender;

            var openPage = new ResourceProfilePage((ResourceView)data.SelectedValue);
            frame.Navigate(openPage);
        }
        private void searchBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var temp = new ObservableCollection<SupplyView>(from x in SupplyList select (SupplyView)x.Clone());
            var filteredList = new ObservableCollection<SupplyView>();

            foreach (var supply in temp)
            {
                if (supply.Contains(searchBox_Copy.Text.ToUpper()))
                    filteredList.Add(supply);
                supplyDataGrid.ItemsSource = filteredList;
            }
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var temp = new ObservableCollection<ResourceView>(from x in ResourceList select (ResourceView)x.Clone());
            var filteredList = new ObservableCollection<ResourceView>();

            foreach (var resource in temp)
            {
                if (resource.Contains(searchBox.Text.ToUpper()))
                    filteredList.Add(resource);
                resourceDataGrid.ItemsSource = filteredList;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ResourceChartPage());
            /*var win2 = new ChartWindow(new ResourceChartPage());
            win2.Show();*/
        }
    }
}
