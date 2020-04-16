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
    /// Logique d'interaction pour RecherchePatient.xaml
    /// </summary>
    /// 
   
    public partial class RecherchePatient : Window
    { public static string passerPatient ="";
       
        public RecherchePatient()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnAdmission.IsEnabled = false;
        }
        private void btnRecherche_Click(object sender, RoutedEventArgs e)
        {
            btnAdmission.IsEnabled = true;
           
            var query =
               from d in Singleton.Instance.hopitalBDD.DossierAdmissions
               join p in Singleton.Instance.hopitalBDD.Patients on d.nss equals p.nss
               join par in Singleton.Instance.hopitalBDD.Parents on p.refParent equals par.refParent
               join c in Singleton.Instance.hopitalBDD.CompagnieAssurances on p.idCompanie equals c.idCompanie
               join m in Singleton.Instance.hopitalBDD.Medecins on d.idMedecin equals m.idMedecin
               select new { d.numLit, d.dateConge,d.dateAdmission, d.idAdmission, p.nss, p.nom, p.prenom, par.telephone,
                   p.adresse,
                   p.codePostal,
                   p.dateNaissance,
                   p.ville,
                   p.province,
                   Medecin = m.nom + " " + m.prenom,
                   Assurance = c.nomCompagnie };
          
            foreach (var item in query.Where(c => c.nss == ("NSS_" + txtRecherche.Text)).ToList())
            {
                txtCompanie.Text = item.Assurance;
                txtContactParent.Text = item.telephone;
                txtDateNais.SelectedDate = item.dateNaissance;
                txtNom.Text = item.nom;
                txtPrenom.Text = item.prenom;
                txtAdresse.Text = item.adresse;
                txtVille.Text = item.ville;
                txtProvince.Text = item.province;
                txtCodePostal.Text = item.codePostal;
                txtTel.Text = item.telephone;

                if (item.dateConge == null)
                {
                    MessageBox.Show("Ce patient est hospitalisé actuellement au Lit : " + item.numLit);
                    btnAdmission.IsEnabled = false;
                }
              
            }
            dgPatientRech.DataContext = query.Where(c => c.nss == ("NSS_" + txtRecherche.Text)).ToList();
        }

        private void btnAdmission_Click(object sender, RoutedEventArgs e)
        {
            passerPatient = ("NSS_" + txtRecherche.Text);
            AjouterAdmission admission = new AjouterAdmission();
            admission.ShowDialog();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtRecherche_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                //Détermine si la séquence de touches est un nombre du clavier.
                if (e.Key < Key.NumPad0 || e.Key > Key.NumPad9)
                {
                    if ((e.Key != Key.Back) && (e.Key != Key.Tab) && (e.Key != Key.OemComma))
                    {
                        e.Handled = true;
                        MessageBox.Show("Veuillez saisir uniquement les chiffres, désolé.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
