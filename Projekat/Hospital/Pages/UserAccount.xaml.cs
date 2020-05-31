using Hospital.Model;
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
    /// Interaction logic for UserAccount.xaml
    /// </summary>
    public partial class UserAccount : Page
    {
        public UserAccount()
        {
            InitializeComponent();
            ManagerView manager = ManagerView.getInstance();
            nameLabel.Content = manager.Name;
            surnameLabel.Content = manager.Surname;
            emailLabel.Content = manager.Email;
            idLabel.Content = manager.Id.ToString();
        }
    }
}
