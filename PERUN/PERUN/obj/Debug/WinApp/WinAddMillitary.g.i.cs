﻿#pragma checksum "..\..\..\WinApp\WinAddMillitary.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "302B058F10D4E6CB192F8ACD20F8E9416D313677F8C4B676F451C4DF98794A84"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PERUN.WinApp;
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


namespace PERUN.WinApp {
    
    
    /// <summary>
    /// WinAddMillitary
    /// </summary>
    public partial class WinAddMillitary : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\WinApp\WinAddMillitary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Photo;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\WinApp\WinAddMillitary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNAddPhoto;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\WinApp\WinAddMillitary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LUrlPhoto;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\WinApp\WinAddMillitary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\WinApp\WinAddMillitary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBAge;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\WinApp\WinAddMillitary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBHeight;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\WinApp\WinAddMillitary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBGender;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\WinApp\WinAddMillitary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/PERUN;component/winapp/winaddmillitary.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WinApp\WinAddMillitary.xaml"
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
            this.Photo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.BTNAddPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\WinApp\WinAddMillitary.xaml"
            this.BTNAddPhoto.Click += new System.Windows.RoutedEventHandler(this.BTNAddPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LUrlPhoto = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TBName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBAge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TBHeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CBGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.BTNAdd = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\WinApp\WinAddMillitary.xaml"
            this.BTNAdd.Click += new System.Windows.RoutedEventHandler(this.BTNAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

