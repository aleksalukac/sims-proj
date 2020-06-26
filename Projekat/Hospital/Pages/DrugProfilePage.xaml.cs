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
    /// Interaction logic for DrugProfilePage.xaml
    /// </summary>
    public partial class DrugProfilePage : Page
    {
        private DrugController _drugController;

        public DrugProfilePage(DrugView drug)
        {
            _drugController = (Application.Current as App).DrugController;
            InitializeComponent();
            nameTextBox.Text = drug.Name;
            quantityTextBox.Text = drug.Count.ToString();

            List<DrugView> alternativeDrugs = new List<DrugView>();

            foreach (var altDrug in DrugPage.DrugList)
            {
                if (drug.alternativeDrug.Contains((int)altDrug.Id))
                {
                    alternativeDrugs.Add(altDrug);
                }
            }
            alternativeListBox.ItemsSource = alternativeDrugs;

            List<DoctorView> approvedDoctors = new List<DoctorView>();
            foreach(var doctor in EmployeesPage.DoctorList)
            {
                if(drug.alternativeDrug.Contains((int)doctor.Id))
                {
                    approvedDoctors.Add(doctor);
                }
            }

            approvedListBox.ItemsSource = approvedDoctors;
            idLabel.Content = drug.Id;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            DrugView _drug = new DrugView();
            _drug.Id = Int32.Parse(idLabel.Content.ToString());
            _drug = new DrugView(_drugController.Get(_drug.Id));
            _drug.Name = nameTextBox.Text;

            if(quantityTextBox.Text.Length == 0)
            {
                _drug.Count = 0;
            }
            else
            {
                string s = quantityTextBox.Text;
                int x = 0;
                int ux;
                if (int.TryParse(s, out ux))
                {
                    x = int.Parse(s);
                }
                _drug.Count = x;
            }

            Drug drug = _drugController.Get(_drug.Id);
            drug = _drug.Convert();
            drug.Id = _drug.Id;
            _drugController.Update(drug);

            if (drug.Approved)
            {
                foreach(var drugView in DrugPage.DrugList)
                {
                    if (drugView.Id == drug.Id)
                    {
                        DrugPage.DrugList.Remove(drugView);
                        break;
                    }
                }
                DrugPage.DrugList.Add(_drug);
            }
            else
            {
                foreach (var drugView in DrugPage.DrugListUnapproved)
                {
                    if (drugView.Id == drug.Id)
                    {
                        DrugPage.DrugListUnapproved.Remove(drugView);
                        break;
                    }
                }
                DrugPage.DrugListUnapproved.Add(_drug);
            }

            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            NavigationService.Navigate(new Page());
        }

        private void quantityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            quantityTextBox.Text = Regex.Replace(quantityTextBox.Text, @"[^\d]", "");
            
        }
    }
}
