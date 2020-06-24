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

namespace Bolnica.Layouts
{
    /// <summary>
    /// Interaction logic for CestaPitanja.xaml
    /// </summary>
    public partial class CestaPitanja : Page
    { public List<Cpitanja> myCpitanja{get;set;}
        
        public CestaPitanja( )
        {
            InitializeComponent();
    
           List<Cpitanja> myCpitanja=new List<Cpitanja>();
            Cpitanja cpitanja1 = new Cpitanja();
            cpitanja1.pitanje = "Da li radite 24h?";
            cpitanja1.odgovor = "Postovani,nasa bolnica radi 24h,sedam dana u nedelji.";

            Cpitanja cpitanja2 = new Cpitanja();
            cpitanja2.pitanje = "Da li se usluge mogu platiti karticom?";
            cpitanja2.odgovor = "Postovani,sve nase usluge mozete platiti karticom. ";

            Cpitanja cpitanja3 = new Cpitanja();
            cpitanja3.pitanje = "Da li imate laboratoriju u sklopu bolnice?";
            cpitanja3.odgovor = "Postovani,nasa bolnica poseduje savremenu laboratoriju za sve vrste ispitivanja .";

            Cpitanja cpitanja4 = new Cpitanja();
            cpitanja4.pitanje = "Da li moram da se registrujem da bih zakazala pregled?";
            cpitanja4.odgovor = "Postovani,mozete kontaktirati sekretara ukoliko ne zelite registraciju,a zelite pregled u nasoj bolnici.";

            Cpitanja cpitanja5 = new Cpitanja();
            cpitanja5.pitanje = "Da li mogu da otkazem pregled iako je proslo 24h do zakazanog termina?";
            cpitanja5.odgovor = "Postovani,mozete kontaktiranjem sekretara,koji ce dati termin otkazati.";



            myCpitanja.Add(cpitanja1);
            myCpitanja.Add(cpitanja2);
            myCpitanja.Add(cpitanja3);
            myCpitanja.Add(cpitanja4);
            myCpitanja.Add(cpitanja5);
            listBox.DataContext = myCpitanja;





        }

       

        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
            
        }

        private void Profil(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
        }
        

       
    }
}
