﻿#pragma checksum "..\..\FenetrePrepose.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D33C8FF221E6EBE0AA0BB9F5564B94A6FB505CD8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Projet_Integrateur;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Projet_Integrateur {
    
    
    /// <summary>
    /// FenetrePrepose
    /// </summary>
    public partial class FenetrePrepose : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 91 "..\..\FenetrePrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNouvAdmis;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\FenetrePrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuitter;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\FenetrePrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gvAdmission;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\FenetrePrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRechPatient;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projet_Integrateur;component/fenetreprepose.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FenetrePrepose.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\FenetrePrepose.xaml"
            ((Projet_Integrateur.FenetrePrepose)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnNouvAdmis = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\FenetrePrepose.xaml"
            this.btnNouvAdmis.Click += new System.Windows.RoutedEventHandler(this.btnNouvAdmis_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnQuitter = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\FenetrePrepose.xaml"
            this.btnQuitter.Click += new System.Windows.RoutedEventHandler(this.btnQuitter_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gvAdmission = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btnRechPatient = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\FenetrePrepose.xaml"
            this.btnRechPatient.Click += new System.Windows.RoutedEventHandler(this.btnRechPatient_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 107 "..\..\FenetrePrepose.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 108 "..\..\FenetrePrepose.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 110 "..\..\FenetrePrepose.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

