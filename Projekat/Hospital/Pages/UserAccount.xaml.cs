﻿using Controllers;
using Hospital.ViewModel;
using Hospital_class_diagram.Crypt;
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
    /// Interaction logic for UserAccount.xaml
    /// </summary>
    public partial class UserAccount : Page
    {
        private UserController _userController;

        public UserAccount()
        {
            _userController = (Application.Current as App).UserController;
            InitializeComponent();

            User user = _userController.GetLoggedUser();

            nameTextBox.Text = user.Name;
            surnameTextBox.Text = user.Surname;
            emailTextBox.Text = user.Email;
            idLabel.Content = user.Id.ToString();

            userTypeLabel.Content = user.GetType().Name;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            User user = _userController.GetLoggedUser();

            if (!passwordBox.Password.Equals(confirmedPasswordBox.Password))
            {
                MessageBox.Show("Sifre se ne poklapaju", "Greska");
                return;
            }
            if(confirmedPasswordBox.Password.Length != 0)
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
            //ManagerView.saveManager();

            _userController.Update(user);

            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");
            NavigationService.Navigate(new Page());
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
    }
}
