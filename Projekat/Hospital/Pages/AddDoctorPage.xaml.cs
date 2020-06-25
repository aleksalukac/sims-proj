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
    /// Interaction logic for AddDoctorPage.xaml
    /// </summary>
    public partial class AddDoctorPage : Page
    {
        private DoctorController _controller;

        public AddDoctorPage(int id)
        {
            _controller = (Application.Current as App).DoctorController;
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            DoctorView lekar = new DoctorView();
            lekar.Name = this.imeTextBox.Text;
            lekar.Surname = this.prezimeTextBox.Text;
            lekar.Specialisation = this.specijalizacijaTextBox.Text;


            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            var emailName = rgx.Replace(lekar.Name, "");
            var emailSurname = rgx.Replace(lekar.Surname, "");
            lekar.Email = emailName.ToLower() + "." + emailSurname.ToLower() + "@clinic.com";

            if (lekar.Name.Length == 0 || lekar.Surname.Length == 0)
            {
                System.Windows.MessageBox.Show("Niste uneli adekvatno ime lekara.");
                return;
            }

            Doctor doctor = lekar.Convert();
            _controller.Add(doctor);

            lekar.Id = (uint)doctor.Id;
            EmployeesPage.AddDoctor(lekar);
            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");

            NavigationService.Navigate(new Page());
        }
    }
}
