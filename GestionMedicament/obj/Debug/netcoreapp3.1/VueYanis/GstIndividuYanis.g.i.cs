﻿#pragma checksum "..\..\..\..\VueYanis\GstIndividuYanis.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CA450159FEA097ABDB006FB9D09B6D5E801BA116"
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
    /// GstIndividuYanis
    /// </summary>
    public partial class GstIndividuYanis : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTypeIndividu;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnCreerMedoc;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnModifier;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstTotalTypeIndividu;
        
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
            System.Uri resourceLocater = new System.Uri("/GestionMedicament;V1.0.0.0;component/vueyanis/gstindividuyanis.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
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
            
            #line 8 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
            ((GestionMedicament.VueYanis.GstIndividuYanis)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 47 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.linkgstMedoc_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 55 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.linkStatique_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtTypeIndividu = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnCreerMedoc = ((System.Windows.Controls.RadioButton)(target));
            
            #line 73 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
            this.btnCreerMedoc.Click += new System.Windows.RoutedEventHandler(this.btnCreerMedoc_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnModifier = ((System.Windows.Controls.RadioButton)(target));
            
            #line 74 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
            this.btnModifier.Click += new System.Windows.RoutedEventHandler(this.btnModifier_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lstTotalTypeIndividu = ((System.Windows.Controls.ListBox)(target));
            
            #line 76 "..\..\..\..\VueYanis\GstIndividuYanis.xaml"
            this.lstTotalTypeIndividu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstTotalTypeIndividu_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

