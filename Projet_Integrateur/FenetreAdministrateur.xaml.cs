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
    /// Logique d'interaction pour FenetreAdministrateur.xaml
    /// </summary>
    public partial class FenetreAdministrateur : Window
    {
        public FenetreAdministrateur()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from m in Singleton.Instance.hopitalBDD.Medecins
            join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
            select new { m.idMedecin, s.descSpecialite, m.prenom, m.nom };
            dgMedecin.DataContext = query.ToList();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GestionMedecin fmedecin = new GestionMedecin();
            fmedecin.ShowDialog();
            var query =
              from m in Singleton.Instance.hopitalBDD.Medecins
              join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
              select new { m.idMedecin, s.descSpecialite, m.prenom, m.nom };
            dgMedecin.DataContext = query.ToList();

        }


        private void btnModifMed_Click_1(object sender, RoutedEventArgs e)
        {
            Consultations fConsultation = new Consultations();
            fConsultation.ShowDialog();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            GestionMedecin fmedecin = new GestionMedecin();
            fmedecin.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Consultations fConsultation = new Consultations();
            fConsultation.ShowDialog();
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
