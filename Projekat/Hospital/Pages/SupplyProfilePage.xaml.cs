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
    /// Interaction logic for SupplyProfilePage.xaml
    /// </summary>
    public partial class SupplyProfilePage : Page
    {
        private MedicalSupplyController _medicalSupplyController;

        private bool isNewSupply = false;

        public SupplyProfilePage(SupplyView supply, bool isPrivate = false)
        {
            isNewSupply = isPrivate;
            _medicalSupplyController = (Application.Current as App).MedicalSupplyController;
            InitializeComponent();

            nameTextBox.Text = supply.Type;
            if(!isNewSupply)
                idLabel.Content = supply.Id;
            countTextBox.Text = supply.Count.ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            SupplyView newSupply = new SupplyView();
            MedicalSupply medicalSupply = new MedicalSupply();

            if (!isNewSupply)
                foreach (var supply in ResourcePage.SupplyList)
                {
                    if (supply.Id == Int32.Parse(idLabel.Content.ToString()))
                    {
                        newSupply = supply;
                        break;
                    }
                }
            else
                newSupply.Id = medicalSupply.Id;

            if(nameTextBox.Text.Length == 0)
            {
                System.Windows.MessageBox.Show("Unesite pravilno ime materijala.");
                return;
            }

            if(!isNewSupply)
                ResourcePage.SupplyList.Remove(newSupply);

            newSupply.Type = nameTextBox.Text;

            string s = countTextBox.Text;
            int x = 0;
            int ux;
            if (int.TryParse(s, out ux))
            {
                x = int.Parse(s) % 24;
            }
            newSupply.Count = x;

            medicalSupply = newSupply.Convert();

            if(!isNewSupply)
            {
                _medicalSupplyController.Update(medicalSupply);
            }
            else
            {
                _medicalSupplyController.Add(medicalSupply);
            }
            ResourcePage.SupplyList.Add(newSupply);

            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            NavigationService.Navigate(new Page());
        }

        private void countTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            countTextBox.Text = Regex.Replace(countTextBox.Text, @"[^\d]", "");
        }

        private void detele(object sender, RoutedEventArgs e)
        {
            if(isNewSupply)
            {
                NavigationService.Navigate(new Page());
                return;
            }

            SupplyView newSupply = null;
            foreach (var supply in ResourcePage.SupplyList)
            {
                if (supply.Id == Int32.Parse(idLabel.Content.ToString()))
                {
                    newSupply = supply;
                    break;
                }
            }
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Da li ste sigurni da zelite da izbrišete ovaj materijal?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                if (_medicalSupplyController.Get(newSupply.Id) != null)
                {
                    _medicalSupplyController.Remove(newSupply.Convert());
                }

                ResourcePage.SupplyList.Remove(newSupply);
                System.Windows.MessageBox.Show("Promene uspešno sačuvane");
                NavigationService.Navigate(new Page());
                return;
            }
        }
    }
}
