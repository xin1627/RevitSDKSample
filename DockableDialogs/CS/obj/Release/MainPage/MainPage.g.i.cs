﻿#pragma checksum "..\..\..\MainPage\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0BFC2CE685350576F3A0F931F8DACC2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Revit.SDK.Samples.DockableDialogs.CS;
using System;
using System.ComponentModel;
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


namespace Revit.SDK.Samples.DockableDialogs.CS {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Revit.SDK.Samples.DockableDialogs.CS.MainPage DockableDialogs;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_stats;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_wpf_stats;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_getById;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_listTabs;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_output;
        
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
            System.Uri resourceLocater = new System.Uri("/DockableDialogs;component/mainpage/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainPage\MainPage.xaml"
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
            this.DockableDialogs = ((Revit.SDK.Samples.DockableDialogs.CS.MainPage)(target));
            return;
            case 2:
            this.btn_stats = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\MainPage\MainPage.xaml"
            this.btn_stats.Click += new System.Windows.RoutedEventHandler(this.PaneInfoButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_wpf_stats = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\MainPage\MainPage.xaml"
            this.btn_wpf_stats.Click += new System.Windows.RoutedEventHandler(this.wpf_stats_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_getById = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\MainPage\MainPage.xaml"
            this.btn_getById.Click += new System.Windows.RoutedEventHandler(this.btn_getById_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_listTabs = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\MainPage\MainPage.xaml"
            this.btn_listTabs.Click += new System.Windows.RoutedEventHandler(this.btn_listTabs_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tb_output = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

