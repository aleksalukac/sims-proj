using Hospital.ViewModel;
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
        public DrugProfilePage(DrugView drug)
        {
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
            DrugView drug = null;
            bool approved = false;
            foreach(var approvedDrug in DrugPage.DrugList)
            {
                if (approvedDrug.Id == Int32.Parse(idLabel.Content.ToString()))
                {
                    drug = approvedDrug;
                    approved = true;
                    DrugPage.DrugList.Remove(drug);
                    break;
                }

            }

            if(drug == null)
            {
                foreach (var unapprovedDrug in DrugPage.DrugListUnapproved)
                {
                    if (unapprovedDrug.Id == Int32.Parse(idLabel.Content.ToString()))
                    {
                        drug = unapprovedDrug;
                        DrugPage.DrugListUnapproved.Remove(drug);
                        break;
                    }
                }

            }


            drug.Name = nameTextBox.Text;
            if(quantityTextBox.Text.Length == 0)
            {
                drug.Count = 0;
            }
            else
            {
                string s = quantityTextBox.Text;
                int x = 0;
                int ux;
                if (int.TryParse(s, out ux))
                {
                    x = int.Parse(s) % 24;
                }
                drug.Count = x;
            }

            if (approved)
            {
                DrugPage.DrugList.Add(drug);
            }
            else
                DrugPage.DrugListUnapproved.Add(drug);

            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            NavigationService.Navigate(new Page());
        }

        private void quantityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            quantityTextBox.Text = Regex.Replace(quantityTextBox.Text, @"[^\d]", "");
            
        }
    }
}
