﻿#pragma checksum "..\..\..\Pages\RoomsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A5BB5BBD989FE6A816F06765409BBEA6438552B5EEBFADF25E618FE04BF9AB15"
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
    /// RoomPage
    /// </summary>
    public partial class RoomPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\RoomsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\RoomsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\RoomsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\RoomsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\RoomsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\RoomsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\RoomsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\RoomsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy3;
        
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
            System.Uri resourceLocater = new System.Uri("/Hospital;component/pages/roomspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\RoomsPage.xaml"
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
            
            #line 17 "..\..\..\Pages\RoomsPage.xaml"
            this.dataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Row_MouseDoubleClick_Prostorije);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.frame = ((System.Windows.Controls.Frame)(target));
            return;
            case 4:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Pages\RoomsPage.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Pages\RoomsPage.xaml"
            this.button_Copy.Click += new System.Windows.RoutedEventHandler(this.renoviranjeClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\RoomsPage.xaml"
            this.button_Copy1.Click += new System.Windows.RoutedEventHandler(this.dodajSobu);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_Copy2 = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\RoomsPage.xaml"
            this.button_Copy2.Click += new System.Windows.RoutedEventHandler(this.urediSobu);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button_Copy3 = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\RoomsPage.xaml"
            this.button_Copy3.Click += new System.Windows.RoutedEventHandler(this.pogledajGrafikon);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

