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
    /// Logique d'interaction pour Facture.xaml
    /// </summary>
    public partial class Facture : Window
    {
        public Facture()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
           var query =
           from p in Singleton.Instance.hopitalBDD.Patients
           join d in Singleton.Instance.hopitalBDD.DossierAdmissions on p.nss equals d.nss
          
           select new { d.idAdmission, p.nss, p.nom, p.prenom,d.dateAdmission,d.dateConge,d.prixCh,d.prixTv,d.prixTel  };

            foreach (var item in query.Where(c => c.idAdmission == FenetreMedecin.dossierFact.idAdmission))
            {
                 DateTime dateAd,dateCong;
                dossier.Content = item.idAdmission;
                nom.Content = item.nom;
                prenom.Content = item.prenom;
                nss.Content = item.nss;
                Tv.Content = Convert.ToString(item.prixTv);
                Tel.Content = Convert.ToString(item.prixTel);
                ch.Content= Convert.ToString(item.prixCh);
                dateAd = Convert.ToDateTime(item.dateAdmission);
                dateAdmiss.Content= dateAd.ToString("yyyy-MM-dd");
                dateCong= Convert.ToDateTime(item.dateConge);
                dateConger.Content = dateCong.ToString("yyyy-MM-dd");

                total.Content = Convert.ToString(item.prixTv+ item.prixTel+ item.prixCh);
               
                if (item.prixCh == 267)
                {
                    txTChambre.Content = "semi-privée";
                }
                else if (item.prixCh == 571)
                {
                    txTChambre.Content = "privée";
                }
                else { txTChambre.Content = "standard"; }
            }  



        }
    }
}
