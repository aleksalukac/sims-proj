﻿#pragma checksum "..\..\..\Pages\ZaposleniPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A21C2AC51F84132AE17C701958030DD25C54687115868F552AF29853A5847B35"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Hospital.Pages;
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


namespace Hospital.Pages {
    
    
    /// <summary>
    /// ZaposleniPage
    /// </summary>
    public partial class ZaposleniPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addDoctor;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Doctorframe;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\ZaposleniPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Hospital;component/pages/zaposlenipage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ZaposleniPage.xaml"
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
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\..\Pages\ZaposleniPage.xaml"
            this.dataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Row_MouseDoubleClick_Lekari);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.dataGrid2 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\..\Pages\ZaposleniPage.xaml"
            this.dataGrid2.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Row_MouseDoubleClick_Sekretari);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Pages\ZaposleniPage.xaml"
            this.dataGrid2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid2_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Pages\ZaposleniPage.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addDoctor = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\ZaposleniPage.xaml"
            this.addDoctor.Click += new System.Windows.RoutedEventHandler(this.addDoctor_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Doctorframe = ((System.Windows.Controls.Frame)(target));
            return;
            case 8:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Pages\ZaposleniPage.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.button_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Pages\ZaposleniPage.xaml"
            this.button_Copy.Click += new System.Windows.RoutedEventHandler(this.button2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

