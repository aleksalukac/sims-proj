using Controllers;
using Hospital.ViewModel;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AddDrug.xaml
    /// </summary>
    public partial class AddDrug : Page
    {
        private DrugController _drugController;
        private DoctorController _doctorController;

        public AddDrug()
        {
            _drugController = (Application.Current as App).DrugController;
            _doctorController = (Application.Current as App).DoctorController;
            InitializeComponent();

            doctorDataGrid.ItemsSource = EmployeesPage.DoctorList;
            dataGrid.ItemsSource = DrugPage.DrugList;
            dataGridAlternativeDrug.ItemsSource = new ObservableCollection<DrugView>();
            //idLabel.Content = id;
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if(nameTextBox.Text.Length == 0)
            {
                System.Windows.MessageBox.Show("Unesite adekvatno ime leka.");
                return;
            }

            DrugView newDrug = new DrugView();
            newDrug.Name = nameTextBox.Text;
            newDrug.Approved = false;

            foreach(var alternativeDrug in dataGridAlternativeDrug.ItemsSource)
            {
                newDrug.alternativeDrug.Add(((DrugView)alternativeDrug).Id);
            }

            int count = 0;

            bool success = Int32.TryParse(quantityTextBox.Text, out count);
            if(success)
            {
                if (doctorDataGrid.SelectedItems.Count < 2)
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Molimo vas unesite bar 2 lekara");
                    return;
                }
                newDrug.Count = count;

                Drug drug = new Drug();
                drug = newDrug.Convert();
                drug.SimilarDrug = newDrug.alternativeDrug;
                newDrug.Id = drug.Id;

                DrugPage.DrugListUnapproved.Add(newDrug);

                List<Doctor> doctors = new List<Doctor>();

                System.Collections.IList selectedDoctors = (System.Collections.IList)doctorDataGrid.SelectedItems;
                
                foreach(var doctor in selectedDoctors)
                {
                    DoctorView dw = (DoctorView)doctor;
                    doctors.Add(_doctorController.Get((int)dw.Id));
                }

                foreach(var doctor in doctors)
                {
                    drug.ApprovedByDoctor.Add(doctor.Id);
                    doctor.drugsToApprove.Add(drug.Id);

                    _doctorController.Update(doctor);

                    _doctorController.AddNewDrugNotification(doctor.Id, drug.Id);
                }

                _drugController.Add(drug);

                System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
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
            System.Collections.IList drugViews = (System.Collections.IList)dataGrid.SelectedItems;

            List<DrugView> list = drugViews.Cast<DrugView>().ToList();

            System.Collections.IList drugViewsAlternative = (System.Collections.IList)dataGridAlternativeDrug.ItemsSource;

            List<DrugView> alternativeList = drugViewsAlternative.Cast<DrugView>().ToList();

            list.AddRange(alternativeList);
            var uniqueList = list.GroupBy(x => x.Id).Select(x => x.First());

            dataGridAlternativeDrug.ItemsSource = uniqueList.Select(item => (DrugView)item.Clone()).ToList();


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

        private void quantityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            quantityTextBox.Text = Regex.Replace(quantityTextBox.Text, @"[^\d]", "");

        }

        private void nameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
