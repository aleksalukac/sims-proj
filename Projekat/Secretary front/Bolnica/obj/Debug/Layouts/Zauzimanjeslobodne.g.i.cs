﻿#pragma checksum "..\..\..\Layouts\Zauzimanjeslobodne.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F33538D5CB3340BC19A96F79740184245EDF02ABE2A855A8E416816D7042C1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bolnica.Layouts;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Bolnica.Layouts {
    
    
    /// <summary>
    /// Zauzimanjeslobodne
    /// </summary>
    public partial class Zauzimanjeslobodne : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox3;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilter;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lvUsers;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/layouts/zauzimanjeslobodne.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
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
            this.comboBox1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
            this.comboBox1.Loaded += new System.Windows.RoutedEventHandler(this.Form1_Load);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
            this.comboBox1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox1_SelectedIndexChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboBox2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.comboBox3 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
            this.comboBox3.Loaded += new System.Windows.RoutedEventHandler(this.Form1_Load1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
            this.txtFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvUsers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            
            #line 29 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Potvrdi);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 30 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Otkazi);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 32 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Tutorijal);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 33 "..\..\..\Layouts\Zauzimanjeslobodne.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

