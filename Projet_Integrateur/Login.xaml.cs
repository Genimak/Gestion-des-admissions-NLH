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
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       //public static DB_HopitalEntities myBDD  =new DB_HopitalEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string utilisateur = txtUtilisateur.Text.Trim().ToLower();
            string motPasse = txtMotPasse.Password.Trim().ToLower();
            if (!String.IsNullOrEmpty(utilisateur) && !String.IsNullOrEmpty(motPasse))
            {
                if ((utilisateur=="medecin") && (motPasse=="medecin"))
                {
                    
                    FenetreMedecin fmedecin =new  FenetreMedecin();
                    fmedecin.ShowDialog();
                    initUser();


                }
                else if ((utilisateur == "prepose") && (motPasse == "prepose"))
                {
                     FenetrePrepose fprepose = new FenetrePrepose();
                    fprepose.ShowDialog();
                    initUser();

                }
                else if ((utilisateur == "admin") && (motPasse == "admin"))
                {
                    FenetreAdministrateur fadministrateur = new FenetreAdministrateur();
                    fadministrateur.ShowDialog();
                    initUser();
                }
                else
                {
                   
                    MessageBox.Show("Mot de pass ou/et username est incorrect");
                    initUser();
                }
            }
            else
            {
                MessageBox.Show("Vous devez saisir votre nom d'utilisateur et votre mot de passe.",
                "Attention",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
                // Nous redonnons le focus à l'élément txtUtilisateur.
                txtUtilisateur.Focus();
            }
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtUtilisateur.Focus();
        }
        public void initUser()
        {
            txtUtilisateur.Text = string.Empty;
            txtMotPasse.Password = string.Empty;
            txtUtilisateur.Focus();
        }
    }
}
