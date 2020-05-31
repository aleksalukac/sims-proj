using Hospital.Model;
using Hospital.Windows;
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
    public partial class ZaposleniPage : Page
    {
        public static ObservableCollection<DoctorView> ListaLekara = new ObservableCollection<DoctorView>();
        public ObservableCollection<EmployeeView> ListaSekretara = new ObservableCollection<EmployeeView>();

        public ObservableCollection<DoctorView> GetListaLekara()
        {
            return ListaLekara;
        }

        public static void RemoveDoctor(uint id)
        {
            List<uint> lista = new List<uint>();
            lista.Add(id);
            ListaLekara.Remove((ListaLekara.Where(x => lista.Contains(x.Id)).First()));
        }

        public void NavigateEmptyPage()
        {
            var openPage = new Page();
            bool v = Doctorframe.Navigate(openPage);
        }

        public static void AddDoctor(DoctorView doctor)
        {
            ListaLekara.Add(doctor);
        }

        public ZaposleniPage()
        {
            InitializeComponent();
            this.DataContext = this;
            var name = RandomData.GetRandomName();
            if(ListaLekara.Count == 0)
            {
                for(int i = 0; i < 10; i++)
                {
                    ListaLekara.Add(new DoctorView(random: true));
                }

            }
            dataGrid.ItemsSource = ListaLekara;

            if(ListaSekretara.Count == 0)
            {
                ListaSekretara.Add(new EmployeeView(random: true));
            }    
            dataGrid2.ItemsSource = ListaSekretara;
            
        }
        private void Row_MouseDoubleClick_Lekari(object sender, MouseButtonEventArgs e)
        {
            var data = (DataGrid)sender;

            var openPage = new DoctorProfilePage((DoctorView)data.SelectedValue);
            Doctorframe.Navigate(openPage);
        }

        private void Row_MouseDoubleClick_Sekretari(object sender, MouseButtonEventArgs e)
        {
            //var nextWindow = DoctorProfile(ListaSekretara[row.])
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var temp = new ObservableCollection<DoctorView>(from x in ListaLekara select (DoctorView)x.Clone());
            var filteredList = new ObservableCollection<DoctorView>();

            foreach(var zaposlen in temp)
            {
                if(comboBox.SelectedIndex == -1)
                {
                    if (zaposlen.Contains(searchBox.Text.ToUpper()))
                        filteredList.Add(zaposlen);
                    dataGrid.ItemsSource = filteredList;
                }
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
    }
}
