using Controllers;
using Hospital.ViewModel;
using Hospital.Windows;
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
    /// Interaction logic for DoctorProfilePage.xaml
    /// </summary>
    public partial class DoctorProfilePage : Page
    {
        private DoctorController _controller;

        public DoctorProfilePage(DoctorView doctor)
        {

            _controller = (Application.Current as App).DoctorController;
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
                _controller.Remove(Int32.Parse(idLabel.Content.ToString()));
                deleteDoctor((uint)Int32.Parse(idLabel.Content.ToString()));
                var page = new Page();
                NavigationService.Navigate(page);
            }

        }

        public void deleteDoctor(uint id)
        {
            EmployeesPage.RemoveDoctor(id);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(emailTextBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email nije u dobrom formatu", "Greska");
                return;
            }
            var doctor = EmployeesPage.DoctorList.Where(x => x.Id == Int32.Parse(idLabel.Content.ToString())).FirstOrDefault();

            EmployeesPage.DoctorList.Remove(doctor);

            doctor.Name = imeTextBox.Text;
            doctor.Surname = prezimeTextBox.Text;
            doctor.Email = emailTextBox.Text;
            if(workBeginTextBox.Text.Length != 0)
            {
                string s = workBeginTextBox.Text;
                int x = 0;
                int ux;
                if (int.TryParse(s, out ux))
                {
                    x = int.Parse(s) % 24;
                }
                doctor.StartWorkingHours = (uint)x;
            }

            if (workEndTextBox.Text.Length != 0)
            {
                string s = workEndTextBox.Text;
                int x = 0;
                int ux;
                if (int.TryParse(s, out ux))
                {
                    x = int.Parse(workEndTextBox.Text) % 24;
                }
                doctor.EndWorkingHours = (uint)x;
                // x = -100
            }
            doctor.Specialisation = specijalizacijaTextBox.Text;

            EmployeesPage.DoctorList.Add(doctor);

            _controller.Update(doctor.Convert());
            //AutoClosingMessageBox.Show("Uspešno ste sačuvali informacije.", "", 10);
            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            NavigationService.Navigate(new Page());
        }

        private void workBeginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            workBeginTextBox.Text = Regex.Replace(workBeginTextBox.Text, @"[^\d]", "");
        }

        private void workEndTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            workEndTextBox.Text = Regex.Replace(workEndTextBox.Text, @"[^\d]", "");
        }

        private void emailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
