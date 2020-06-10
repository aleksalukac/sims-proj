using Hospital.Model;
using System;
using System.Collections;
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
    /// Interaction logic for AddDrug.xaml
    /// </summary>
    public partial class AddDrug : Page
    {
        public AddDrug(int id)
        {
            InitializeComponent();

            dataGrid.ItemsSource = DrugPage.DrugList;
            dataGridAlternativeDrug.ItemsSource = new ObservableCollection<DrugView>();
            idLabel.Content = id;
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            DrugView drug = new DrugView();
            drug.Name = nameTextBox.Text;
            drug.Approved = false;
            //tried with Linq, didn't work

            foreach(var alternativeDrug in dataGridAlternativeDrug.ItemsSource)
            {
                drug.alternativeDrug.Add(((DrugView)alternativeDrug).Id);
            }

            int count = 0;
            bool success = Int32.TryParse(quantityTextBox.Text, out count);
            if(success)
            {
                drug.Count = count;

                // DEBUG FOR APPROVED DOCTOR
                if(drug.Count == 333)
                {
                    drug.approvedByDoctor.Add(3);
                    drug.approvedByDoctor.Add(5);
                }
                // END DEBUG

                DrugPage.DrugListUnapproved.Add(drug);
                var page = new Page();
                NavigationService.Navigate(page);
            }
            else
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Molimo vas unesite pravilno informacije o leku.");
            }
        }

        private void addDrug_Click(object sender, RoutedEventArgs e)
        {
            //List<DrugView> drugViews = (List<DrugView>)dataGrid.SelectedItems.ToList();

            System.Collections.IList drugViews = (System.Collections.IList)dataGrid.SelectedItems;

            List<DrugView> list = drugViews.Cast<DrugView>().ToList();

            System.Collections.IList drugViewsAlternative = (System.Collections.IList)dataGridAlternativeDrug.ItemsSource;

            List<DrugView> alternativeList = drugViewsAlternative.Cast<DrugView>().ToList();

            list.AddRange(alternativeList);
            //list = list.GroupBy(x => x.Id).Select(x => x.First());
            // list = list.DistinctBy(i => i.Id);
            //var set = new HashSet<DrugView>(list);
            var uniqueList = list.GroupBy(x => x.Id).Select(x => x.First());

            dataGridAlternativeDrug.ItemsSource = uniqueList.Select(item => (DrugView)item.Clone()).ToList();

            //var collection = items.Cast<PuzzleViewModel>();

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void deleteDrug(object sender, RoutedEventArgs e)
        {
            var alternativeDrugList = (System.Collections.IList)dataGridAlternativeDrug.ItemsSource;
            List<DrugView> list = alternativeDrugList.Cast<DrugView>().ToList();

            foreach(DrugView drug in (System.Collections.IList)dataGridAlternativeDrug.SelectedItems)
            {
                list.Remove(drug);
            }

            dataGridAlternativeDrug.ItemsSource = list;
        }
    }
}
