﻿#pragma checksum "..\..\..\..\VueYanis\PerturbateurYanis.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B483E325AC889EDEBED18AF1D3CAC0EA6792FEE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestionMedicament.VueYanis;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace GestionMedicament.VueYanis {
    
    
    /// <summary>
    /// Perturbateur
    /// </summary>
    public partial class Perturbateur : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Graphiques;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstMedoc;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstMedicPertub;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstMedocNonPer;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAjouter;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestionMedicament;V1.0.0.0;component/vueyanis/perturbateuryanis.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
            ((GestionMedicament.VueYanis.Perturbateur)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 49 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.linkgstMedoc_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 57 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.linkGstIdv_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Graphiques = ((System.Windows.Controls.RadioButton)(target));
            
            #line 69 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
            this.Graphiques.Click += new System.Windows.RoutedEventHandler(this.Graphiques_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lstMedoc = ((System.Windows.Controls.ListBox)(target));
            
            #line 83 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
            this.lstMedoc.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstMedoc_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstMedicPertub = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.lstMedocNonPer = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.btnAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\..\VueYanis\PerturbateurYanis.xaml"
            this.btnAjouter.Click += new System.Windows.RoutedEventHandler(this.btnAjouter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

