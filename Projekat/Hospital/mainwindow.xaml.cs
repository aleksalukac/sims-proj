using Hospital.Pages;
using Hospital.Windows;
using Hospital.ViewModel;
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
using Model;
using Repository;
using Controllers;

namespace Hospital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserController _userController;

        public MainWindow()
        {
            _userController = (Application.Current as App).UserController;
            InitializeComponent();
        }

        private void reset_password_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new ResetPasswordWindow();
            nextWindow.Show();
        }

        private void login_Copy2_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new ProblemReportWindow();
            nextWindow.Show();
        }

        private void login_Copy1_Click(object sender, RoutedEventArgs e)
        {
            string passwordText = passwordBox.Password; //Crypt.Encrypt()
            string emailText = emailBox.Text;

            User loggedUser = _userController.Login(emailText, passwordText);

            if (loggedUser == null)
            {
                MessageBox.Show("Email i sifra nisu prepoznati", "Greska");
            }
            else
            {
                if (loggedUser.GetType().Name.Equals("Manager"))
                {
                    var nextPage = new DefaultPage();
                    this.Content = nextPage;
                }
                else
                {
                    var nextPage = new UserAccountLogged();
                    this.Content = nextPage;
                }
            }
        }

        private void passwordsBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void login_Copy3_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new ResetPasswordWindow();
            nextWindow.Show();
        }

        private void managerRepositoryTest()
        {
            var _managerRepository = new ManagerRepository();
            Manager manager = new Manager();
            manager.Name = "Nolo";
            manager.Surname = "Djokovic";
            manager.Email = "nole@clinic.com";
            var a = _managerRepository.Add(manager);
            var b = _managerRepository.Add(manager);

            var man = _managerRepository.Get();

            man.Name = "Novak";

            man = _managerRepository.Update(man);
        }

        private void roomRepositoryTest()
        {
            var _roomRepository = new RoomRepository();
            List<Room> rooms = new List<Room>();
            _roomRepository.WriteAll(rooms);

            Room r = new Room();
            r.RoomType = Model.RoomType.examinationRoom;
            _roomRepository.Add(r);

            r = new Room();
            r.RoomType = Model.RoomType.operationRoom;
            _roomRepository.Add(r);

            rooms = _roomRepository.GetAll();

            _roomRepository.Update(r);

            rooms = _roomRepository.GetAll();

            _roomRepository.Remove(0);

            rooms = _roomRepository.GetAll();
        }
    }
}
