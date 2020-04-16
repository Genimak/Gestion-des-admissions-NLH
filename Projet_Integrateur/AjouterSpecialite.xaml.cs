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
    /// Logique d'interaction pour AjouterSpecialite.xaml
    /// </summary>
    public partial class AjouterSpecialite : Window
    {
        public AjouterSpecialite()
        {
            InitializeComponent();
        }

        private void tbnAjout_Click(object sender, RoutedEventArgs e)
        {
            Specialite spe = new Specialite();
            spe.idSpecialite = "SPE_" + txtIdSpecialite.Text;
            spe.descSpecialite = txtNomSpecialite.Text;
            if (txtIdSpecialite.Text != string.Empty && txtNomSpecialite.Text != string.Empty)
            {

                if (ValidationSpe("SPE_" + txtIdSpecialite.Text))
                {
                    MessageBox.Show("L'ID spécialité existe déjà. Veuillez ressayer !");
                }
                else
                {
                    try
                    {
                        Singleton.Instance.hopitalBDD.Specialites.Add(spe);
                        Singleton.Instance.hopitalBDD.SaveChanges();
                        MessageBox.Show("Ajout de spécialité avec succes");
                        dgSpecialite.DataContext = Singleton.Instance.hopitalBDD.Specialites.ToList();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    txtIdSpecialite.Text = string.Empty;
                    txtNomSpecialite.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tbnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtIdComp_PreviewKeyDown(object sender, KeyEventArgs e)
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgSpecialite.DataContext = Singleton.Instance.hopitalBDD.Specialites.ToList();
            txtIdSpecialite.Focus();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (dgSpecialite.SelectedIndex != -1)
            {

                try
                {
                    Singleton.Instance.hopitalBDD.Specialites.Remove((Specialite)dgSpecialite.SelectedItem);
                    Singleton.Instance.hopitalBDD.SaveChanges();
                    MessageBox.Show("Spécialité supprimer avec succées");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Aucune spécialité n'est selectionée!",
                "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            dgSpecialite.DataContext = null;
            dgSpecialite.DataContext = Singleton.Instance.hopitalBDD.Specialites.ToList();
        }

        private void tbnAnnuler_Click(object sender, RoutedEventArgs e)
        {
           txtIdSpecialite.Text= string.Empty; 
            txtNomSpecialite.Text= string.Empty; 
        }
        public bool ValidationSpe(string IDSpe)
        {
            for (int i = 0; i < Singleton.Instance.hopitalBDD.Specialites.Count(); i++)
            {
                if (Singleton.Instance.hopitalBDD.Specialites.ToList()[i].descSpecialite == IDSpe)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
