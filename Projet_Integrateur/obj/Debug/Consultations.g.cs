﻿#pragma checksum "..\..\Consultations.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EB9D110BAB98952F66D754AFE4B6B26800EBB139"
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
    /// Consultations
    /// </summary>
    public partial class Consultations : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\Consultations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgMedecin;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Consultations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gvAdmission;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Consultations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar pbAdmiss;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Consultations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label capacite;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\Consultations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label disponible;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Consultations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label disponible_Copy;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\Consultations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label occupe;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\Consultations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label specialite;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Consultations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuiter;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet_Integrateur;component/consultations.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Consultations.xaml"
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
            
            #line 8 "..\..\Consultations.xaml"
            ((Projet_Integrateur.Consultations)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgMedecin = ((System.Windows.Controls.DataGrid)(target));
            
            #line 57 "..\..\Consultations.xaml"
            this.dgMedecin.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgMedecin_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gvAdmission = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.pbAdmiss = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 5:
            this.capacite = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.disponible = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.disponible_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.occupe = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.specialite = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btnQuiter = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\Consultations.xaml"
            this.btnQuiter.Click += new System.Windows.RoutedEventHandler(this.btnQuiter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
