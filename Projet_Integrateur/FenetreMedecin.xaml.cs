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
    /// Logique d'interaction pour FenetreMedecin.xaml
    /// </summary>
    public partial class FenetreMedecin : Window
    {
        public static DossierAdmission dossierFact = null;
        public FenetreMedecin()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dateAdmission.IsEnabled = false;
   
            var query =

             from p in Singleton.Instance.hopitalBDD.Patients
             join d in Singleton.Instance.hopitalBDD.DossierAdmissions on p.nss equals d.nss
             join l in Singleton.Instance.hopitalBDD.Lits on d.numLit equals l.numLit
             join m in Singleton.Instance.hopitalBDD.Medecins on d.idMedecin equals m.idMedecin

             select new { d.nss, l.numLit, l.occupe, d.idAdmission, p.nom, p.prenom, d.dateConge,d.dateAdmission, Medecin = m.prenom + " " + m.nom };

            dgAdmission.DataContext = query.Where(dos => dos.dateConge == null).ToList();
            cbadmission.DataContext = Singleton.Instance.hopitalBDD.DossierAdmissions.Where(dos => dos.dateConge == null).ToList();
            cbadmission.SelectedIndex = 0;
        }
        private void btnConger_Click(object sender, RoutedEventArgs e)
        {
            var queryDoss =

            from p in Singleton.Instance.hopitalBDD.Patients
            join d in Singleton.Instance.hopitalBDD.DossierAdmissions on p.nss equals d.nss
            join l in Singleton.Instance.hopitalBDD.Lits on d.numLit equals l.numLit
            join m in Singleton.Instance.hopitalBDD.Medecins on d.idMedecin equals m.idMedecin

            select new { d.nss, l.numLit, l.occupe, d.idAdmission, p.nom, p.prenom, d.dateConge, d.dateAdmission, Medecin = m.prenom + " " + m.nom };


            dossierFact = (DossierAdmission)cbadmission.SelectedItem;

            if (cbadmission.SelectedItem != null)
            {
                if (!String.IsNullOrEmpty(dateConge.Text))
                {
                    DossierAdmission patientConge = (DossierAdmission)cbadmission.SelectedItem;
                    var query = Singleton.Instance.hopitalBDD.Lits.Where(l => l.numLit == patientConge.numLit).ToList();
                    foreach (var item in query)
                    {
                        item.occupe = false;
                    }
                    patientConge.dateConge = dateConge.SelectedDate;

                    Singleton.Instance.hopitalBDD.SaveChanges();
                    MessageBox.Show("Le patient est en congé");

                    if (dossierFact.prixCh + dossierFact.prixTel + dossierFact.prixTv == 0)
                    {
                        MessageBox.Show("Pas de facture a payé !");
                    }
                    else
                    {
                        Facture facture = new Facture();
                        facture.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Entrer une date de congé !");
                }

                cbadmission.DataContext = cbadmission.DataContext = Singleton.Instance.hopitalBDD.DossierAdmissions.Where(dos => dos.dateConge == null).ToList();
               
                dgAdmission.DataContext = queryDoss.Where(dos => dos.dateConge == null).ToList();
                dateConge.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Pas d'admission !");
            }
        }

        private void cbadmission_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DossierAdmission dossAdmi = (DossierAdmission)cbadmission.SelectedItem;
            Patient patient = new Patient();
            if (cbadmission.SelectedItem != null)
            {
                txtNss.Text = dossAdmi.nss;
                txtLit.Text = dossAdmi.numLit;
                dateAdmission.SelectedDate = dossAdmi.dateAdmission;
                var query = Singleton.Instance.hopitalBDD.Patients.Where(p => p.nss == dossAdmi.nss).ToList();
                foreach (var item in query)
                {
                    txtNom.Text = item.nom;
                    txtPrenom.Text = item.prenom;
                }
            }
            else
            {
                txtNss.Text = "";
                txtLit.Text = "";
            }
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
