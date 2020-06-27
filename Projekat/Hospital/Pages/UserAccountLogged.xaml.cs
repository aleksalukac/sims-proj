using Controllers;
using Hospital_class_diagram.Controllers;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    /// Interaction logic for UserAccountLogged.xaml
    /// </summary>
    public partial class UserAccountLogged : Page
    {
        private UserController _userController;
        private DoctorController _doctorController;
        private NotificationController _notificationController;
        private DrugController _drugController;

        public UserAccountLogged()
        {
            _userController = (Application.Current as App).UserController;
            _doctorController = (Application.Current as App).DoctorController;
            _drugController = (Application.Current as App).DrugController;
            _notificationController = (Application.Current as App).NotificationController;
            InitializeComponent();

            User user = _userController.GetLoggedUser();

            nameTextBox.Text = user.Name;
            surnameTextBox.Text = user.Surname;
            emailTextBox.Text = user.Email;
            idLabel.Content = user.Id.ToString();

            userTypeLabel.Content = user.GetType().Name;

            Doctor doctor = _doctorController.Get(user.Id);
            if(doctor != null)
            {
                notificationDataGrid.Visibility = Visibility.Visible;

                List<Notification> notifications = new List<Notification>();

                foreach (var notificationId in doctor.Notification)
                    notifications.Add(_notificationController.Get(notificationId));

                notificationDataGrid.ItemsSource = notifications;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            User user = _userController.GetLoggedUser();

            if (!passwordBox.Password.Equals(confirmedPasswordBox.Password))
            {
                MessageBox.Show("Sifre se ne poklapaju", "Greska");
                return;
            }
            if (confirmedPasswordBox.Password.Length != 0)
            {
                if (confirmedPasswordBox.Password.Length < 6)
                {
                    MessageBox.Show("Sifra je prekratka", "Greska");
                    return;
                }
                user.Password = confirmedPasswordBox.Password;
            }
            user.Name = nameTextBox.Text;
            user.Surname = surnameTextBox.Text;

            if (!IsValid(emailTextBox.Text))
            {
                MessageBox.Show("Email nije dobrog formata", "Greska");
                return;
            }

            user.Email = emailTextBox.Text;
            user.Name = nameTextBox.Text;

            _userController.Update(user);

            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            MainWindow main = new MainWindow();
            App.Current.MainWindow = main;
            Window.GetWindow(this).Close();
            main.Show();
        }

        public static bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void Row_MouseDoubleClick_ApproveDrug(object sender, MouseButtonEventArgs e)
        {
            var data = (DataGrid)sender;
            Notification notification = (Notification)data.SelectedValue;
            if (notification == null)
                return;
            var drugId = Regex.Match(notification.Text, @"\d+").Value;

            Drug drug = _drugController.Get(Int32.Parse(drugId));

            if(drug != null)
            {
                User user = _userController.GetLoggedUser();
                Doctor doctor = _doctorController.Get(user.Id);

                drug = _drugController.Approve(drug.Id, doctor.Id);               

                if(drug != null)
                {
                    doctor.Notification.Remove(notification.Id);
                    doctor = _doctorController.Update(doctor);

                    List<Notification> notifications = new List<Notification>();

                    foreach (var notificationId in doctor.Notification)
                        notifications.Add(_notificationController.Get(notificationId));

                    notificationDataGrid.ItemsSource = notifications;

                }

            }


        }

        private void notificationDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
