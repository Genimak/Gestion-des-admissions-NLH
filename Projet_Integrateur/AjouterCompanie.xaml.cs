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
    /// Logique d'interaction pour AjouterCompanie.xaml
    /// </summary>
    public partial class AjouterCompanie : Window
    {
        public AjouterCompanie()
        {
            InitializeComponent();
        }

        private void tbnAjout_Click(object sender, RoutedEventArgs e)
        {
            CompagnieAssurance comp = new CompagnieAssurance();
            comp.idCompanie = "CA_" + txtIdComp.Text;
            comp.nomCompagnie = txtNomComp.Text;
            if (txtIdComp.Text != string.Empty && txtNomComp.Text != string.Empty)
            {

                if (ValidationComp("CA_" + txtIdComp.Text))
                {
                    MessageBox.Show("L'ID d'companie existe déjà. Veuillez ressayer !");
                }
                else
                {
                    try
                    {
                        Singleton.Instance.hopitalBDD.CompagnieAssurances.Add(comp);
                        Singleton.Instance.hopitalBDD.SaveChanges();
                        MessageBox.Show("Ajout de companie avec succes");
                        dgAssurance.DataContext = Singleton.Instance.hopitalBDD.CompagnieAssurances.ToList();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    txtIdComp.Text = string.Empty;
                    txtNomComp.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
          
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgAssurance.DataContext = Singleton.Instance.hopitalBDD.CompagnieAssurances.ToList();
            txtIdComp.Focus();
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

        private void tbnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (dgAssurance.SelectedIndex != -1)
            {

                try
                {
                    Singleton.Instance.hopitalBDD.CompagnieAssurances.Remove((CompagnieAssurance)dgAssurance.SelectedItem);
                    Singleton.Instance.hopitalBDD.SaveChanges();
                    MessageBox.Show("Compagnie d'assurance supprimer avec succées");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Aucune Compagnie d'assurance n'est selectionée!",
                "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            dgAssurance.DataContext = null;
            dgAssurance.DataContext = Singleton.Instance.hopitalBDD.CompagnieAssurances.ToList();
        }

        private void tbnAnnuler_Click(object sender, RoutedEventArgs e)
        {
           txtIdComp.Text=string.Empty;
            txtNomComp.Text= string.Empty;
        }
        public bool ValidationComp(string IDComp)
        {
            for (int i = 0; i < Singleton.Instance.hopitalBDD.CompagnieAssurances.Count(); i++)
            {
                if (Singleton.Instance.hopitalBDD.CompagnieAssurances.ToList()[i].idCompanie == IDComp)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
