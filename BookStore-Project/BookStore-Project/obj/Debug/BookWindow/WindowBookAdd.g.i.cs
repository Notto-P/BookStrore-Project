﻿#pragma checksum "..\..\..\BookWindow\WindowBookAdd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89E6CA389849D2DA1928B4B57314753120964743"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BookStore_Project;
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


namespace BookStore_Project {
    
    
    /// <summary>
    /// WindowBookAdd
    /// </summary>
    public partial class WindowBookAdd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\BookWindow\WindowBookAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookID;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\BookWindow\WindowBookAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookTitle;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\BookWindow\WindowBookAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookDescription;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\BookWindow\WindowBookAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookPrice;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\BookWindow\WindowBookAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\BookWindow\WindowBookAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_reset;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\BookWindow\WindowBookAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_back;
        
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
            System.Uri resourceLocater = new System.Uri("/BookStore-Project;component/bookwindow/windowbookadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BookWindow\WindowBookAdd.xaml"
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
            this.tb_BookID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_BookTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_BookDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_BookPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\BookWindow\WindowBookAdd.xaml"
            this.tb_BookPrice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Tb_BookPrice_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\BookWindow\WindowBookAdd.xaml"
            this.btn_add.Click += new System.Windows.RoutedEventHandler(this.Btn_add_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_reset = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\BookWindow\WindowBookAdd.xaml"
            this.btn_reset.Click += new System.Windows.RoutedEventHandler(this.Btn_reset_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_back = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\BookWindow\WindowBookAdd.xaml"
            this.btn_back.Click += new System.Windows.RoutedEventHandler(this.Btn_back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

