﻿#pragma checksum "..\..\..\AppWindows\ChatRoomWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "823570C8B408BECC297880854D734DF057CB8B4A80DC63AB83C8442E18D7A389"
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
    /// ChatRoomWindow
    /// </summary>
    public partial class ChatRoomWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\AppWindows\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVEmployees;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\AppWindows\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddUser;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AppWindows\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BChangeTopic;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\AppWindows\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BLeave;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\AppWindows\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBMessage;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\AppWindows\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSend;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\AppWindows\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVChatMessages;
        
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
            System.Uri resourceLocater = new System.Uri("/ChitChat;component/appwindows/chatroomwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AppWindows\ChatRoomWindow.xaml"
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
            this.LVEmployees = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.BAddUser = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\AppWindows\ChatRoomWindow.xaml"
            this.BAddUser.Click += new System.Windows.RoutedEventHandler(this.BAddUser_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BChangeTopic = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\AppWindows\ChatRoomWindow.xaml"
            this.BChangeTopic.Click += new System.Windows.RoutedEventHandler(this.BChangeTopic_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BLeave = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\AppWindows\ChatRoomWindow.xaml"
            this.BLeave.Click += new System.Windows.RoutedEventHandler(this.BLeave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TBMessage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BSend = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\AppWindows\ChatRoomWindow.xaml"
            this.BSend.Click += new System.Windows.RoutedEventHandler(this.BSend_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LVChatMessages = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

