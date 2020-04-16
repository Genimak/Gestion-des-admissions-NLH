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
using System.Windows.Shapes;

namespace Projet_Integrateur
{
    /// <summary>
    /// Logique d'interaction pour FenetrePrepose.xaml
    /// </summary>
    public partial class FenetrePrepose : Window
    {
        public FenetrePrepose()
        {
            InitializeComponent();
        }

      

        private void btnNouvAdmis_Click(object sender, RoutedEventArgs e)
        {
            AjouterAdmission admission = new AjouterAdmission();
            admission.ShowDialog();

        }

      
        private void btnRechPatient_Click(object sender, RoutedEventArgs e)
        {
            RecherchePatient RechPatient = new RecherchePatient();
            RechPatient.ShowDialog();
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
                var query =
                      from p in Singleton.Instance.hopitalBDD.Patients
                      join d in Singleton.Instance.hopitalBDD.DossierAdmissions on p.nss equals d.nss
                      join m in Singleton.Instance.hopitalBDD.Medecins on d.idMedecin equals m.idMedecin
                      join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
                      select new { d.idAdmission, p.nss, p.nom, p.prenom, m.idMedecin, s.descSpecialite, Medecin = m.prenom + " " + m.nom };
  
            gvAdmission.DataContext = query.ToList();
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AjouterAdmission admission = new AjouterAdmission();
            admission.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            RecherchePatient RechPatient = new RecherchePatient();
            RechPatient.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
