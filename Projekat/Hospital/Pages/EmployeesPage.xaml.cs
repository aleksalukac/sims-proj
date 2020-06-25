using Controllers;
using Hospital.ViewModel;
using Hospital.Windows;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Zaposleni.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        private DoctorController _doctorController;
        private EmployeeController _employeeController;
        public static ObservableCollection<DoctorView> DoctorList = new ObservableCollection<DoctorView>();
        public static ObservableCollection<EmployeeView> SecretaryList = new ObservableCollection<EmployeeView>();

        public ObservableCollection<DoctorView> GetListaLekara()
        {
            return DoctorList;
        }

        public static void RemoveDoctor(uint id)
        {
            List<uint> lista = new List<uint>();
            lista.Add(id);
            DoctorList.Remove((DoctorList.Where(x => lista.Contains(x.Id)).First()));
        }

        public void NavigateEmptyPage()
        {
            var openPage = new Page();
            bool v = Doctorframe.Navigate(openPage);
        }

        public static void AddDoctor(DoctorView doctor)
        {
            DoctorList.Add(doctor);
        }

        public EmployeesPage()
        {
            _doctorController = (Application.Current as App).DoctorController;
            _employeeController = (Application.Current as App).EmployeeController;

            InitializeComponent();
            this.DataContext = this;
            var name = RandomData.GetRandomName();
            if(DoctorList.Count == 0)
            {
                List<Doctor> doctors = new List<Doctor>();
                doctors = _doctorController.GetAllDoctor();

                for(int i = 0; i < doctors.Count; i++)
                {
                    DoctorList.Add(new DoctorView(doctors[i]));
                }

            }
            dataGrid.ItemsSource = DoctorList;

            if(SecretaryList.Count == 0)
            {
                SecretaryList.Add(new EmployeeView((Employee)_employeeController.Get()));
            }    
            dataGrid2.ItemsSource = SecretaryList;
            
        }

        private void Row_MouseDoubleClick_Lekari(object sender, MouseButtonEventArgs e)
        {
            var data = (DataGrid)sender;

            var openPage = new DoctorProfilePage((DoctorView)data.SelectedValue);
            Doctorframe.Navigate(openPage);
        }

        private void Row_MouseDoubleClick_Sekretari(object sender, MouseButtonEventArgs e)
        {
            var data = (DataGrid)sender;

            var openPage = new SecretaryProfilePage((EmployeeView)data.SelectedValue);
            Doctorframe.Navigate(openPage);
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var temp = new ObservableCollection<DoctorView>(from x in DoctorList select (DoctorView)x.Clone());
            var filteredList = new ObservableCollection<DoctorView>();

            foreach(var zaposlen in temp)
            {
                if (zaposlen.Contains(searchBox.Text.ToUpper()))
                    filteredList.Add(zaposlen);
                dataGrid.ItemsSource = filteredList;
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addDoctor_Click(object sender, RoutedEventArgs e)
        {
            var openPage = new AddDoctorPage((int)EmployeeView.countId);
            Doctorframe.Navigate(openPage);
        }

        private void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid2.SelectedItem != null)
            {
                var openPage = new SecretaryProfilePage((EmployeeView)dataGrid2.SelectedItem);
                Doctorframe.Navigate(openPage);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                var openPage = new DoctorProfilePage((DoctorView)dataGrid.SelectedItem);
                Doctorframe.Navigate(openPage);
            }
        }
    }
}
