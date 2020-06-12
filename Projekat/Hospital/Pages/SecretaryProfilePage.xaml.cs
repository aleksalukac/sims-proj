using Hospital.Model;
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
    /// Interaction logic for SecretaryProfilePage.xaml
    /// </summary>
    public partial class SecretaryProfilePage : Page
    {
        public SecretaryProfilePage(EmployeeView secretary)
        {
            InitializeComponent();
            imeTextBox.Text = secretary.Name;
            prezimeTextBox.Text = secretary.Surname;
            emailTextBox.Text = secretary.Email;
            workBeginTextBox.Text = secretary.StartWorkingHours.ToString();
            workEndTextBox.Text = secretary.EndWorkingHours.ToString();
            idLabel.Content = secretary.Id.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(emailTextBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email nije u dobrom formatu", "Greska");
                return;
            }
            var doctor = ZaposleniPage.SecretaryList.Where(x => x.Id == Int32.Parse(idLabel.Content.ToString())).FirstOrDefault();

            doctor.Name = imeTextBox.Text;
            doctor.Surname = prezimeTextBox.Text;
            doctor.Email = emailTextBox.Text;
            doctor.StartWorkingHours = (uint)Int32.Parse(workBeginTextBox.Text);
            doctor.EndWorkingHours = (uint)Int32.Parse(workEndTextBox.Text);

            NavigationService.Navigate(new Page());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void workBeginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            workBeginTextBox.Text = Regex.Replace(workBeginTextBox.Text, @"[^\d]", "");
        }

        private void workEndTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            workEndTextBox.Text = Regex.Replace(workEndTextBox.Text, @"[^\d]", "");
        }
    }
}
