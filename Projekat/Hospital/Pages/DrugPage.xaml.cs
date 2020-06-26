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
    /// Interaction logic for DrugPage.xaml
    /// </summary>
    public partial class DrugPage : Page
    {
        private DrugController _drugController;

        public static ObservableCollection<DrugView> DrugList = new ObservableCollection<DrugView>();
        public static ObservableCollection<DrugView> DrugListUnapproved = new ObservableCollection<DrugView>();

        public DrugPage()
        {
            _drugController = (Application.Current as App).DrugController;
            InitializeComponent();
            DrugList = new ObservableCollection<DrugView>(); 
            DrugListUnapproved = new ObservableCollection<DrugView>();


            List<Drug> drugs = new List<Drug>();
            drugs = _drugController.GetAll();

            for (int i = 0; i < drugs.Count; i++)
            {
                if (drugs[i].Approved)
                    DrugList.Add(new DrugView(drugs[i]));
                else
                    DrugListUnapproved.Add(new DrugView(drugs[i]));
            }

            dataGrid.ItemsSource = DrugList;
            dataGridAlternativeDrug.ItemsSource = DrugListUnapproved;
        }

        private void searchBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var temp = new ObservableCollection<DrugView>(from x in DrugListUnapproved select (DrugView)x.Clone());
            var filteredList = new ObservableCollection<DrugView>();

            foreach (var zaposlen in temp)
            {
                if (zaposlen.Contains(searchBox2.Text.ToUpper()))
                    filteredList.Add(zaposlen);
                dataGridAlternativeDrug.ItemsSource = filteredList;
            }
        }
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var temp = new ObservableCollection<DrugView>(from x in DrugList select (DrugView)x.Clone());
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

            var openPage = new DrugProfilePage((DrugView)data.SelectedValue);
            Drugframe.Navigate(openPage);
        }
        
        private void graph_Click(object sender, RoutedEventArgs e)
        {
            var openPage = new DrugChartPage();
            Drugframe.Navigate(openPage);
        }

        private void addDrug_Click(object sender, RoutedEventArgs e)
        {
            var openPage = new AddDrug();
            Drugframe.Navigate(openPage);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void openDrugProfile(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedItem != null)
            {
                var openPage = new DrugProfilePage((DrugView)dataGrid.SelectedItem);
                Drugframe.Navigate(openPage);
            }
        }

        private void unapprovedOpenDrugProfile(object sender, RoutedEventArgs e)
        {
            if(dataGridAlternativeDrug.SelectedItem != null)
            {
                var openPage = new DrugProfilePage((DrugView)dataGridAlternativeDrug.SelectedItem);
                Drugframe.Navigate(openPage);
            }
        }
    }
}
