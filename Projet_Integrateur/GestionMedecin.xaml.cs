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
    /// Logique d'interaction pour GestionMedecin.xaml
    /// </summary>
    public partial class GestionMedecin : Window
    {
        public GestionMedecin()
        {
            InitializeComponent();
        }

        private void tbnAjout_Click(object sender, RoutedEventArgs e)
        {
            var query =
           from m in Singleton.Instance.hopitalBDD.Medecins
           join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
           select new { m.idMedecin, s.descSpecialite, m.prenom, m.nom };
            Medecin medecin = new Medecin();
            if (txtIdMedecin.Text != string.Empty && txtNom.Text != string.Empty && txtPrenom.Text != string.Empty && cbSpecialite.Text != string.Empty)
            {

                if (Validation("MED_" + txtIdMedecin.Text))
                {
                    MessageBox.Show("L'ID du medecin existe déjà. Veuillez ressayer !");
                }
                else
                {
                    medecin.idMedecin = "MED_" + txtIdMedecin.Text;
                    medecin.nom = txtNom.Text;
                    medecin.prenom = txtPrenom.Text;
                    medecin.idSpecialite = ((Specialite)(cbSpecialite.SelectedItem)).idSpecialite;
                    Singleton.Instance.hopitalBDD.Medecins.Add(medecin);

                    try
                    {
                        Singleton.Instance.hopitalBDD.SaveChanges();
                        MessageBox.Show("Ajout de médecin avec succes");

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                dgMedecinSupp.DataContext = query.ToList();
                cbMedecin.DataContext = Singleton.Instance.hopitalBDD.Medecins.ToList();
                cbMedecin_Supp.DataContext = Singleton.Instance.hopitalBDD.Medecins.ToList();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            txtIdMedecin.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtIdMedecin.Focus();
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {

            var query =
           from m in Singleton.Instance.hopitalBDD.Medecins
           join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
           select new { m.idMedecin, s.descSpecialite, m.prenom, m.nom };


            Medecin medecin = (Medecin)cbMedecin.SelectedItem;

            medecin.nom = txtNom_Modif.Text;
            medecin.prenom = txtPrenom_Modif.Text;
            medecin.idSpecialite = ((Specialite)cbSpecialite_Modif.SelectedItem).idSpecialite; //txtSpecialite.Text;


            try
            {
                Singleton.Instance.hopitalBDD.SaveChanges();
                MessageBox.Show("Modification du médecin avec succés");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgMedecinSupp.DataContext = query.ToList();
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            var query =
           from m in Singleton.Instance.hopitalBDD.Medecins
           join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
           select new { m.idMedecin, s.descSpecialite, m.prenom, m.nom };

            Medecin medecin = (Medecin)cbMedecin_Supp.SelectedItem;
            Singleton.Instance.hopitalBDD.Medecins.Remove(medecin);


            try
            {
                Singleton.Instance.hopitalBDD.SaveChanges();
                MessageBox.Show("Médecin supprimer avec succées");
                dgMedecinSupp.DataContext = Singleton.Instance.hopitalBDD.Medecins.ToList();
                cbMedecin_Supp.DataContext = Singleton.Instance.hopitalBDD.Medecins.ToList();
                cbMedecin_Supp.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgMedecinSupp.DataContext = query.ToList();
           
        }

        private void btnSpe_Click(object sender, RoutedEventArgs e)
        {
            AjouterSpecialite fspecialite = new AjouterSpecialite();
            fspecialite.ShowDialog();
            btnRefreche.Visibility = Visibility.Visible;
            btnSpe.Visibility = Visibility.Collapsed; 
        }

        private void txtIdMedecin_PreviewKeyDown(object sender, KeyEventArgs e)
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

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cbMedecin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Medecin medecin = cbMedecin.SelectedItem as Medecin;
            int a = Convert.ToInt32((medecin.idSpecialite).Substring(4));

            txtNom_Modif.Text = medecin.nom;
            txtPrenom_Modif.Text = medecin.prenom;
            cbSpecialite_Modif.DataContext = Singleton.Instance.hopitalBDD.Specialites.ToList();
            cbSpecialite_Modif.SelectedIndex = a - 1;
        }

        private void cbMedecin_Supp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Medecin medecin = cbMedecin_Supp.SelectedItem as Medecin;
            txtNom_Supp.Text = medecin.nom;
            txtPrenom_Supp.Text = medecin.prenom;
        }
        public bool Validation(string IDMedecin)
        {
            for (int i = 0; i < Singleton.Instance.hopitalBDD.Medecins.Count(); i++)
            {
                if (Singleton.Instance.hopitalBDD.Medecins.ToList()[i].idMedecin == IDMedecin)
                {
                    return true;
                }
            }
            return false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtIdMedecin.Focus();
            var query =
          from m in Singleton.Instance.hopitalBDD.Medecins
          join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
          select new { m.idMedecin, s.descSpecialite, m.prenom, m.nom };
            dgMedecinSupp.DataContext = query.ToList();

            cbSpecialite.DataContext = Singleton.Instance.hopitalBDD.Specialites.ToList();
            cbSpecialite_Modif.DataContext = Singleton.Instance.hopitalBDD.Specialites.ToList();
            cbMedecin.DataContext = Singleton.Instance.hopitalBDD.Medecins.ToList();
            cbMedecin_Supp.DataContext = Singleton.Instance.hopitalBDD.Medecins.ToList();
        }

        private void tbnAnnuler_Click(object sender, RoutedEventArgs e)
        {
           txtIdMedecin.Text = string.Empty; 
           txtNom.Text = string.Empty; 
          txtPrenom.Text = string.Empty; 
        }

       
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            btnRefreche.Visibility = Visibility.Collapsed;
            btnSpe.Visibility = Visibility.Visible;
        }

        private void btnRefreche_Click(object sender, RoutedEventArgs e)
        {
            btnRefreche.Visibility = Visibility.Collapsed;
            btnSpe.Visibility =  Visibility.Visible;
            cbSpecialite.DataContext = Singleton.Instance.hopitalBDD.Specialites.ToList();
        }
    }
}
