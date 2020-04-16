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
    /// Logique d'interaction pour AjouterAdmission.xaml
    /// </summary>
    /// 

    public partial class AjouterAdmission : Window
    {
        public double prixChambre;
        public double prixTotal;
      public AjouterAdmission()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtNss.Focus();
            DateChirurgie.IsEnabled = false;
            if (Singleton.Instance.hopitalBDD.Lits.Where(l => l.occupe == false).Count()==0)
            {
                MessageBox.Show("Désolé Pas de lit disponnible !");
            }

            var query =
            from p in Singleton.Instance.hopitalBDD.Patients
            join d in Singleton.Instance.hopitalBDD.DossierAdmissions on p.nss equals d.nss
            join m in Singleton.Instance.hopitalBDD.Medecins on d.idMedecin equals m.idMedecin
            join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
            select new { d.idAdmission, p.nss, p.nom, p.prenom, m.idMedecin, s.descSpecialite, Medecin = m.prenom + " " + m.nom,d.dateAdmission , d.dateConge };
            gvAdmission.DataContext = query.ToList();
          
            dgPatient.DataContext = Singleton.Instance.hopitalBDD.Patients.ToList();
            dgListeParent.DataContext = Singleton.Instance.hopitalBDD.Parents.ToList();
            cbMedecin.DataContext = Singleton.Instance.hopitalBDD.Medecins.ToList();
            cbMedecin.SelectedIndex = 0;
                      
            if (RecherchePatient.passerPatient != "")
            {
                tcPatient.IsEnabled = false;
                   var Patient =
                       from p in Singleton.Instance.hopitalBDD.Patients
                       select new {  p.nss, p.nom, p.prenom,p.adresse,p.codePostal,p.CompagnieAssurance,
                                     p.dateNaissance,p.idCompanie,p.refParent,
                                     p.ville,p.province,p.telephone
                                     };

                foreach (var item in Patient.Where(p => p.nss == RecherchePatient.passerPatient).ToList())
                {
                       txtNss.Text = item.nss.Substring(4);
                       txtNomPatient.Text = item.nom;
                       txtPrenomPatient.Text = item.prenom;
                       txtDateNais.SelectedDate = item.dateNaissance;
                       txtAdrPatient.Text = item.adresse;
                       txtVillePatient.Text = item.ville;
                       txtProvincePatient.Text = item.province;
                       txtCpPatient.Text = item.codePostal;
                       txtTelPatient.Text = item.telephone;
                    
                       cbParent.DataContext = Singleton.Instance.hopitalBDD.Parents.Where(p => p.refParent == item.refParent).ToList();
                       cbParent.SelectedIndex = 0;

                       cbCompanieAss.DataContext= Singleton.Instance.hopitalBDD.CompagnieAssurances.Where(c => c.idCompanie == item.idCompanie).ToList();
                       cbCompanieAss.SelectedIndex = 0;
                      
                       if (item.idCompanie == "CA_007")
                          {
                              rbPublic.IsChecked = true;
                          }
                          else
                          {
                              rbPrive.IsChecked = true;
                          }
                        }
            }
            else
            {
                cbParent.DataContext = Singleton.Instance.hopitalBDD.Parents.ToList();
                cbCompanieAss.DataContext = Singleton.Instance.hopitalBDD.CompagnieAssurances.ToList();
                cbCompanieAss.SelectedIndex = 0;
                cbParent.SelectedIndex = 0;
               
            }

            }
        

        private void rbOui_Checked(object sender, RoutedEventArgs e)
        {
            DateChirurgie.IsEnabled = true;
            int nbrLit = 0;
            var query =
            from d in Singleton.Instance.hopitalBDD.Departements
            join l in Singleton.Instance.hopitalBDD.Lits on d.idDepartement equals l.idDepartement
          
            select new { l.numLit, l.occupe, d.idDepartement };
            if (txtDateNais.Text != string.Empty)
            {
                foreach (var item in query.Where(l => l.occupe == false && l.idDepartement == "DEP_01").ToList())
                {
                    nbrLit++;
                }
                if (nbrLit != 0)
                {
                    cbDepartement.DataContext = Singleton.Instance.hopitalBDD.Departements.Where(d => d.idDepartement == "DEP_01").ToList();
                    cbMedecin.DataContext = Singleton.Instance.hopitalBDD.Medecins.Where(m => m.idSpecialite == "SPE_01").ToList();
                    cbMedecin.SelectedIndex = 0;
                }
                else
                {
                    cbDepartement.DataContext = Singleton.Instance.hopitalBDD.Departements.Where(d => d.idDepartement != "DEP_01").ToList();
                    cbDepartement.SelectedIndex = 0;
                    cbMedecin.DataContext = Singleton.Instance.hopitalBDD.Medecins.Where(m => m.idSpecialite != "SPE_01").ToList();
                    cbMedecin.SelectedIndex = 0;
                    MessageBox.Show("Pas de lit disponnible au département");
                }
                cbDepartement.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Veuillez saisir les coordonnées du patient .", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void rbNon_Checked(object sender, RoutedEventArgs e)
        {
            cbDepartement.IsEnabled = true;
            DateChirurgie.IsEnabled = false;
            int nbrLit = 0;
            var query =
            from d in Singleton.Instance.hopitalBDD.Departements
            join l in Singleton.Instance.hopitalBDD.Lits on d.idDepartement equals l.idDepartement
       
            select new { l.numLit,  l.occupe, d.idDepartement };
            if (txtDateNais.Text != string.Empty)
            {

                int age = ((DateTime.Today.Year) - (txtDateNais.DisplayDate.Year));
                if (age > 16)
                {

                    cbDepartement.DataContext = Singleton.Instance.hopitalBDD.Departements.ToList();
                    cbDepartement.SelectedIndex = 0;
                    cbMedecin.DataContext = Singleton.Instance.hopitalBDD.Medecins.Where(m => m.idSpecialite != "SPE_01" && m.idSpecialite != "SPE_02").ToList();
                    cbMedecin.SelectedIndex = 0;
                }
                else
                {

                    foreach (var item in query.Where(l => l.occupe == false && l.idDepartement == "DEP_02").ToList())
                    {
                        nbrLit++;
                    }
                    if (nbrLit != 0)
                    {
                        cbDepartement.DataContext = Singleton.Instance.hopitalBDD.Departements.Where(d => d.idDepartement == "DEP_02").ToList();
                        cbMedecin.DataContext = Singleton.Instance.hopitalBDD.Medecins.Where(m =>m.idSpecialite == "SPE_02").ToList();
                        cbMedecin.SelectedIndex = 0;
                    }
                    else
                    {
                        cbDepartement.DataContext = Singleton.Instance.hopitalBDD.Departements.Where(d => d.idDepartement != "DEP_02").ToList();
                        cbDepartement.SelectedIndex = 0;
                        cbMedecin.DataContext = Singleton.Instance.hopitalBDD.Medecins.Where(m => m.idSpecialite != "SPE_02").ToList();
                        cbMedecin.SelectedIndex = 0;
                        MessageBox.Show("Pas de lit disponnible au département pédiatrie");
                    }
                    cbDepartement.SelectedIndex = 0;
                }
                cbDepartement.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Veuillez saisir les coordonnées du patient .", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void txtNumAdmiss_PreviewKeyDown(object sender, KeyEventArgs e)
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




        private void cbTypeLit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbDepartement.SelectedIndex != -1)
            {
                int nbrCH=Singleton.Instance.hopitalBDD.Lits.Where(l => l.occupe == false && l.numeroType == ((TypeLit)(cbTypeLit.SelectedItem)).numeroType && l.idDepartement == ((Departement)(cbDepartement.SelectedItem)).idDepartement).Count();

            if (nbrCH == 0)
            {
                MessageBox.Show("pas de lits disponible de ce Type \n dans ce département !");
                cbLit.DataContext = null;
            }
            else
            {


                cbLit.DataContext = Singleton.Instance.hopitalBDD.Lits.Where(l => l.occupe == false && l.numeroType == ((TypeLit)(cbTypeLit.SelectedItem)).numeroType && l.idDepartement == ((Departement)(cbDepartement.SelectedItem)).idDepartement).ToList();
                    if (rbPublic.IsChecked == false && rbPrive.IsChecked == false)
                    {
                        MessageBox.Show("Veuillez choisir un type d'assurance.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        if (rbPublic.IsChecked == true)
                        {
                            int nbrLits = 0;
                            nbrLits = Singleton.Instance.hopitalBDD.Lits.Where(l => l.occupe == false && l.numeroType == "1" && l.idDepartement == ((Departement)(cbDepartement.SelectedItem)).idDepartement).ToList().Count();

                            if (nbrLits != 0)
                            {

                                if (((TypeLit)(cbTypeLit.SelectedItem)).description == "semi-privée")
                                {
                                    MessageBox.Show("Il ya :" + nbrLits + "Standard disponible ! des frais en plus vous serez facturé");
                                    prixChambre = 267;
                                }
                                else if (((TypeLit)(cbTypeLit.SelectedItem)).description == "privée")
                                {
                                    MessageBox.Show("Il ya :" + nbrLits + "Standard disponible ! des frais en plus vous serez facturé");
                                    prixChambre = 571;

                                }
                                else { prixChambre = 0; }
                            }
                            prixTotal += prixChambre;
                           }
                        else
                        {
                            prixChambre = 0;

                        }
                    }
            }
            }
            else
                MessageBox.Show("Aucun departement n'est selectioné!",
                "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

      
       

        private void txtNss_PreviewKeyDown(object sender, KeyEventArgs e)
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

        private void txtRefParent_PreviewKeyDown(object sender, KeyEventArgs e)
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

        private void btnAjouterParent_Click(object sender, RoutedEventArgs e)
        {
            Parent parent = new Parent();

            if (ValidationParent("PAR_" + txtRefParent.Text))
            {
                MessageBox.Show("L'ID Parent existe déjà. Veuillez ressayer !");
            }
            else
            {
                if (!String.IsNullOrEmpty(txtRefParent.Text) 
                       && !String.IsNullOrEmpty(txtNomParent.Text) && !String.IsNullOrEmpty(txtPrenomParent.Text)
                       && !String.IsNullOrEmpty(txtAdrParent.Text)
                       && !String.IsNullOrEmpty(txtVilleParent.Text) && !String.IsNullOrEmpty(txtProvinceParent.Text)
                       && !String.IsNullOrEmpty(txtCpParent.Text) && !String.IsNullOrEmpty(txtTelParent.Text))
                {
                    parent.refParent = "PAR_" + txtRefParent.Text;
                    parent.nom = txtNomParent.Text;
                    parent.prenom = txtPrenomParent.Text;
                    parent.adresse = txtAdrParent.Text;
                    parent.ville = txtVilleParent.Text;
                    parent.province = txtProvinceParent.Text;
                    parent.codepostal = txtCpParent.Text;

                    parent.telephone = txtTelParent.Text;
                 

                    try
                    {
                        Singleton.Instance.hopitalBDD.Parents.Add(parent);
                        Singleton.Instance.hopitalBDD.SaveChanges();
                        cbParent.DataContext = null;
                        cbParent.DataContext = Singleton.Instance.hopitalBDD.Parents.ToList();
                        MessageBox.Show("Parent ajouté avec sucées");
                        initParent();
                  
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Tous Les champs sont obligatoires !");
                }
                }
        }

        private void btnAjouterPatient_Click(object sender, RoutedEventArgs e)
        {    Patient nouveauPatient = new Patient();

            if (ValidationPatient("NSS_" + txtNss.Text))
            {
                MessageBox.Show("L'ID Patient (NSS) existe déjà. Veuillez ressayer !");
            }
            else
            {
                if (rbPublic.IsChecked == false && rbPrive.IsChecked == false)
                {
                    MessageBox.Show("Veuillez choisir un type d'assurance.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {

                    if (!String.IsNullOrEmpty(txtNss.Text) && !String.IsNullOrEmpty(cbParent.Text)
                        && !String.IsNullOrEmpty(txtNomPatient.Text) && !String.IsNullOrEmpty(txtPrenomPatient.Text)
                        && !String.IsNullOrEmpty(txtDateNais.Text) && !String.IsNullOrEmpty(txtAdrPatient.Text)
                        && !String.IsNullOrEmpty(txtVillePatient.Text) && !String.IsNullOrEmpty(txtProvincePatient.Text)
                        && !String.IsNullOrEmpty(txtCpPatient.Text) && !String.IsNullOrEmpty(txtTelPatient.Text))
                    {

                        nouveauPatient.nss = "NSS_" + txtNss.Text;
                        nouveauPatient.dateNaissance = txtDateNais.DisplayDate;
                        nouveauPatient.nom = txtNomPatient.Text;
                        nouveauPatient.prenom = txtPrenomPatient.Text;
                        nouveauPatient.adresse = txtAdrPatient.Text;
                        nouveauPatient.ville = txtVillePatient.Text;
                        nouveauPatient.province = txtProvincePatient.Text;
                        nouveauPatient.codePostal = txtCpPatient.Text;
                        nouveauPatient.telephone = txtTelPatient.Text;
                        nouveauPatient.idCompanie = ((CompagnieAssurance)cbCompanieAss.SelectedItem).idCompanie;
                        nouveauPatient.refParent = ((Parent)cbParent.SelectedItem).refParent;
                     
                        try
                        {
                            Singleton.Instance.hopitalBDD.Patients.Add(nouveauPatient);
                            Singleton.Instance.hopitalBDD.SaveChanges();
                            dgPatient.DataContext = null;
                            dgPatient.DataContext = Singleton.Instance.hopitalBDD.Patients.ToList();
                            MessageBox.Show("Patient ajouté avec sucées");

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tous Les champs sont obligatoires !");
                    }
                }
            }
        }

        private void btnComp_Click(object sender, RoutedEventArgs e)
        {
            AjouterCompanie fcomp = new AjouterCompanie();
            fcomp.ShowDialog();

        }

        private void btnParent_Click(object sender, RoutedEventArgs e)
        {
            tcPatient.SelectedIndex = 1;
        }

        private void rbPublic_Checked(object sender, RoutedEventArgs e)
        {
            if (RecherchePatient.passerPatient == "")
            {
                cbCompanieAss.DataContext = Singleton.Instance.hopitalBDD.CompagnieAssurances.Where(c => c.idCompanie == "CA_007").ToList();
                cbCompanieAss.SelectedIndex = 0;
            }
        }

        private void rbPrive_Checked(object sender, RoutedEventArgs e)
        {
            if (RecherchePatient.passerPatient == "")
            {
                cbCompanieAss.DataContext = Singleton.Instance.hopitalBDD.CompagnieAssurances.Where(c => c.idCompanie != "CA_007").ToList();
                cbCompanieAss.SelectedIndex = 0;
            }
        }

        private void btnAjoutAdmiss_Click(object sender, RoutedEventArgs e)
        {
            DossierAdmission admission = new DossierAdmission();
         if (txtNumAdmiss.Text != string.Empty && txtNss.Text != string.Empty && cbLit.Text != string.Empty && cbMedecin.Text != string.Empty && DateAdmission.Text != string.Empty)
          {
               
                if (ValidationAdmi("ADMI_" + txtNumAdmiss.Text))
                {
                    MessageBox.Show("L'ID d'admission existe déjà. Veuillez ressayer !");
                }
                else
                {
                    if (!ValidationPatient("NSS_" + txtNss.Text))
                    {
                        MessageBox.Show("L'ID Patient (NSS) n'existe pas. Veuillez l'ajouter !");
                    }
                    else
                    {
                        if (rbPublic.IsChecked == false && rbPrive.IsChecked == false)
                        {
                            MessageBox.Show("Veuillez choisir un type d'assurance.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            if (rbOui.IsChecked == false && rbNon.IsChecked == false)
                            {
                                MessageBox.Show("Veuillez selectionner si la chirurgie est programme ou non !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            else
                            {
                                if (rbPublic.IsChecked == true)
                                {
                                    if (cekTv.IsChecked == true)
                                    {
                                        admission.prixTv = 42.50;
                                        prixTotal += 42.50;
                                    }
                                    else { admission.prixTv = 0; }
                                    if (cekTel.IsChecked == true)
                                    {
                                        admission.prixTel = 7.50;
                                        prixTotal += 7.50;
                                    }
                                    else { admission.prixTel = 0; }
                                }
                                else
                                {
                                    admission.prixTv = 0;
                                    admission.prixTel = 0;
                                }

                                if (rbOui.IsChecked == true)
                                {
                                    if (DateChirurgie.Text != string.Empty)
                                    {
                                        admission.chirurgieProgramme = true;
                                        admission.dateChirurgie = DateChirurgie.SelectedDate;
                                        admission.idAdmission = ("ADMI_" + txtNumAdmiss.Text);
                                        admission.nss = ("NSS_" + txtNss.Text);
                                        admission.dateAdmission = (DateAdmission.SelectedDate);
                                        admission.numLit = ((Lit)cbLit.SelectedItem).numLit;
                                        ((Lit)cbLit.SelectedItem).occupe = true;
                                        admission.idMedecin = ((Medecin)cbMedecin.SelectedItem).idMedecin;
                                        admission.prixCh = prixChambre;

                                        try
                                        {
                                            Singleton.Instance.hopitalBDD.DossierAdmissions.Add(admission);
                                            Singleton.Instance.hopitalBDD.SaveChanges();
                                            MessageBox.Show("Admission ajouter avec succées");
                                            initAdmission();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Veuillez saisir la date de chirurgie ! ");
                                    }

                                }
                                else
                                {
                                    admission.chirurgieProgramme = false;
                                    admission.idAdmission = ("ADMI_" + txtNumAdmiss.Text);
                                    admission.nss = ("NSS_" + txtNss.Text);
                                    admission.dateAdmission = (DateAdmission.SelectedDate);
                                    admission.numLit = ((Lit)cbLit.SelectedItem).numLit;
                                    ((Lit)cbLit.SelectedItem).occupe = true;
                                    admission.idMedecin = ((Medecin)cbMedecin.SelectedItem).idMedecin;
                                    admission.prixCh = prixChambre;

                                    try
                                    {
                                        Singleton.Instance.hopitalBDD.DossierAdmissions.Add(admission);
                                        Singleton.Instance.hopitalBDD.SaveChanges();
                                        MessageBox.Show("Admission ajouter avec succées");
                                        initAdmission();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                        }
                    }
                }
              }
                else
              {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
             }

            var query =
              from p in Singleton.Instance.hopitalBDD.Patients
              join d in Singleton.Instance.hopitalBDD.DossierAdmissions on p.nss equals d.nss
              join m in Singleton.Instance.hopitalBDD.Medecins on d.idMedecin equals m.idMedecin
              join s in Singleton.Instance.hopitalBDD.Specialites on m.idSpecialite equals s.idSpecialite
              select new { d.idAdmission, p.nss, p.nom, p.prenom, m.idMedecin, s.descSpecialite, Medecin = m.prenom + " " + m.nom, d.dateConge,d.dateAdmission };
            gvAdmission.DataContext = query.ToList();
           
        }
     

        public void initAdmission()
        {
            RecherchePatient.passerPatient = null;
          
            tcPatient.IsEnabled = true;
            txtNumAdmiss.Text = string.Empty;
            txtNss.Text = string.Empty;
            cbLit.Text = string.Empty;
            cbMedecin.Text = string.Empty;
            txtNomPatient.Text = string.Empty;
            txtPrenomPatient.Text = string.Empty;
            txtTelPatient.Text = string.Empty;
            txtVillePatient.Text = string.Empty;
            txtProvincePatient.Text = string.Empty;
            txtCpPatient.Text = string.Empty;
            txtAdrPatient.Text = string.Empty;
            cbParent.DataContext = Singleton.Instance.hopitalBDD.Parents.ToList();
            cbParent.SelectedIndex = 0;
            cbDepartement.DataContext = Singleton.Instance.hopitalBDD.Departements.ToList();
            cbDepartement.SelectedIndex = 0;
            RecherchePatient.passerPatient = "";
            txtDateNais.Text  = string.Empty;
            DateAdmission.Text = string.Empty;
            DateChirurgie.Text = string.Empty;
            DateChirurgie.IsEnabled = false;
            cekTv.IsChecked = false;
            cekTel.IsChecked = false;
            txtNss.Focus();

        }
        public void initPatient()
        {
            txtNss.Text = string.Empty;
            txtNomPatient.Text = string.Empty;
            txtPrenomPatient.Text = string.Empty;
            txtTelPatient.Text = string.Empty;
            txtVillePatient.Text = string.Empty;
            txtProvincePatient.Text = string.Empty;
            txtCpPatient.Text = string.Empty;
            txtAdrPatient.Text = string.Empty;
            txtDateNais.Text = string.Empty;
            txtNss.Focus();
        }
        public void initParent()
        {
            txtRefParent.Text = string.Empty;
            txtNomParent.Text = string.Empty;
            txtPrenomParent.Text = string.Empty;
            txtTelParent.Text = string.Empty;
            txtVilleParent.Text = string.Empty;
            txtProvinceParent.Text = string.Empty;
            txtCpParent.Text = string.Empty;
           txtAdrParent.Text = string.Empty;
            txtRefParent.Focus();
        }

        private void btnNouvPatient_Click(object sender, RoutedEventArgs e)
        {
            RecherchePatient RechPatient = new RecherchePatient();
            RechPatient.ShowDialog();
            this.Close();
        }

        private void btnAnnuler_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
        private void btnInitPar_Click(object sender, RoutedEventArgs e)
        {
            initParent();
        }

        private void btnReinitial_Click(object sender, RoutedEventArgs e)
        {
            tcPatient.IsEnabled = true;
            initAdmission();
        }

        private void dgListeParent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgListeParent.SelectedIndex != -1)
            {

                try
                {
                    
                    dgListePatient.DataContext = Singleton.Instance.hopitalBDD.Patients.Where(p => p.refParent == ((Parent)dgListeParent.SelectedItem).refParent).ToList();
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
        public bool ValidationAdmi(string IDAdmiss)
        {
            for (int i = 0; i < Singleton.Instance.hopitalBDD.DossierAdmissions.Count(); i++)
            {
                if (Singleton.Instance.hopitalBDD.DossierAdmissions.ToList()[i].idAdmission == IDAdmiss)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ValidationParent(string IDParent)
        {
            for (int i = 0; i < Singleton.Instance.hopitalBDD.Parents.Count(); i++)
            {
                if (Singleton.Instance.hopitalBDD.Parents.ToList()[i].refParent == IDParent)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ValidationPatient(string IDPatient)
        {
            for (int i = 0; i < Singleton.Instance.hopitalBDD.Patients.Count(); i++)
            {
                if (Singleton.Instance.hopitalBDD.Patients.ToList()[i].nss == IDPatient)
                {
                    return true;
                }
            }
            return false;
        }

        private void cbDepartement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbTypeLit.DataContext = Singleton.Instance.hopitalBDD.TypeLits.ToList();
            cbTypeLit.SelectedIndex = 0;
        }
         

        private void btnInitPatient_Click(object sender, RoutedEventArgs e)
        {
            initPatient();
        }
    }
}