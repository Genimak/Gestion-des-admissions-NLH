﻿#pragma checksum "..\..\FenetreMedecin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3AD2DC542E643DECF96B7396A53BE48813A97D10"
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
    /// FenetreMedecin
    /// </summary>
    public partial class FenetreMedecin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 88 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbadmission;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNss;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLit;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateAdmission;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateConge;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConger;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuitter;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAdmission;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNom;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\FenetreMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrenom;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet_Integrateur;component/fenetremedecin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FenetreMedecin.xaml"
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
            
            #line 8 "..\..\FenetreMedecin.xaml"
            ((Projet_Integrateur.FenetreMedecin)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbadmission = ((System.Windows.Controls.ComboBox)(target));
            
            #line 88 "..\..\FenetreMedecin.xaml"
            this.cbadmission.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbadmission_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtNss = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtLit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dateAdmission = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.dateConge = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.btnConger = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\FenetreMedecin.xaml"
            this.btnConger.Click += new System.Windows.RoutedEventHandler(this.btnConger_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnQuitter = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\FenetreMedecin.xaml"
            this.btnQuitter.Click += new System.Windows.RoutedEventHandler(this.btnQuitter_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgAdmission = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.txtNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

