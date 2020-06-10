using Hospital.Model;
using Hospital.Windows;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for DoctorProfilePage.xaml
    /// </summary>
    public partial class DoctorProfilePage : Page
    {
        public DoctorProfilePage(DoctorView doctor)
        {
            InitializeComponent();
            imeTextBox.Text = doctor.Name;
            prezimeTextBox.Text = doctor.Surname;
            emailTextBox.Text = doctor.Email;
            workBeginTextBox.Text = doctor.StartWorkingHours.ToString();
            workEndTextBox.Text = doctor.EndWorkingHours.ToString();
            idLabel.Content = doctor.Id.ToString();
            specijalizacijaTextBox.Text = doctor.Specialisation;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Da li ste sigurni da zelite da date otkaz ovom lekaru?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                deleteDoctor((uint)Int32.Parse(idLabel.Content.ToString()));
                var page = new Page();
                NavigationService.Navigate(page);
            }

        }

        public void deleteDoctor(uint id)
        {
            ZaposleniPage.RemoveDoctor(id);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var doctor = ZaposleniPage.DoctorList.Where(x => x.Id == Int32.Parse(idLabel.Content.ToString())).FirstOrDefault();

            doctor.Name = imeTextBox.Text;
            doctor.Surname = prezimeTextBox.Text;
            doctor.Email = emailTextBox.Text;
            doctor.StartWorkingHours = (uint)Int32.Parse(workBeginTextBox.Text);
            doctor.EndWorkingHours = (uint)Int32.Parse(workEndTextBox.Text);
            doctor.Specialisation = specijalizacijaTextBox.Text;

            NavigationService.Navigate(new Page());
        }
    }
}
