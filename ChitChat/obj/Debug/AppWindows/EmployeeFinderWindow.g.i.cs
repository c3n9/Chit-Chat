﻿#pragma checksum "..\..\..\AppWindows\EmployeeFinderWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2BE975B357795C67C3A958567897F234F45AF6C296596E6932273B085FF1A54"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ChitChat.AppWindows;
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


namespace ChitChat.AppWindows {
    
    
    /// <summary>
    /// EmployeeFinderWindow
    /// </summary>
    public partial class EmployeeFinderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CBAdmin;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CBITHelpdesk;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CBEngineering;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CBSales;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CBMarketing;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearch;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVEmployees;
        
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
            System.Uri resourceLocater = new System.Uri("/ChitChat;component/appwindows/employeefinderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
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
            this.CBAdmin = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBAdmin.Checked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBAdmin.Unchecked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CBITHelpdesk = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBITHelpdesk.Checked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBITHelpdesk.Unchecked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CBEngineering = ((System.Windows.Controls.CheckBox)(target));
            
            #line 40 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBEngineering.Checked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBEngineering.Unchecked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CBSales = ((System.Windows.Controls.CheckBox)(target));
            
            #line 50 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBSales.Checked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBSales.Unchecked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CBMarketing = ((System.Windows.Controls.CheckBox)(target));
            
            #line 60 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBMarketing.Checked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            
            #line 61 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.CBMarketing.Unchecked += new System.Windows.RoutedEventHandler(this.Check_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\..\AppWindows\EmployeeFinderWindow.xaml"
            this.TBSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LVEmployees = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

