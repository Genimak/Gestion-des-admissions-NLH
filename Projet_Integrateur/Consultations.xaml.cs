using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Logique d'interaction pour Consultations.xaml
    /// </summary>
    public partial class Consultations : Window
    {
        public Consultations()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int litOccupee = Singleton.Instance.hopitalBDD.Lits.Where(l => l.occupe == true).Count();
            int litTot = Singleton.Instance.hopitalBDD.Lits.Count();
            dgMedecin.DataContext = Singleton.Instance.hopitalBDD.Medecins.ToList();
            double value = ((double)litOccupee / litTot) * 100;

            pbAdmiss.Value = value;
            capacite.Content = Convert.ToInt32(litTot);
            disponible.Content = Convert.ToInt32(litTot- litOccupee);
            occupe.Content = Convert.ToInt32(litOccupee);

        }

        private void dgMedecin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgMedecin.SelectedIndex != -1)
            {
                var query =
                          from p in Singleton.Instance.hopitalBDD.Patients
                          join d in Singleton.Instance.hopitalBDD.DossierAdmissions on p.nss equals d.nss
                          join m in Singleton.Instance.hopitalBDD.Medecins on d.idMedecin equals m.idMedecin
                          join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
                          select new { d.idAdmission, p.nss, p.nom, p.prenom, m.idMedecin, s.descSpecialite,  d.dateAdmission,d.dateConge,d.dateChirurgie };

                try
                {
                    foreach (var item in query.Where(d => d.idMedecin == ((Medecin)dgMedecin.SelectedItem).idMedecin).ToList())
                    {
                        specialite.Content = item.descSpecialite;
                    }
  
                    gvAdmission.DataContext = query.Where(d => d.idMedecin == ((Medecin)dgMedecin.SelectedItem).idMedecin).ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Aucun parent n'est selectioné!",
                "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

        }
        private void btnQuiter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
