﻿#pragma checksum "..\..\..\BookWindow\WindowBookEdit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70C051B507326DC1AA9F654D795E29EC1E365EB7"
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
    /// WindowBookEdit
    /// </summary>
    public partial class WindowBookEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\BookWindow\WindowBookEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookID;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\BookWindow\WindowBookEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookTitle;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\BookWindow\WindowBookEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookDescription;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\BookWindow\WindowBookEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookPrice;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\BookWindow\WindowBookEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_edit;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\BookWindow\WindowBookEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_find;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\BookWindow\WindowBookEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_back;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\BookWindow\WindowBookEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Reset;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\BookWindow\WindowBookEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_find;
        
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
            System.Uri resourceLocater = new System.Uri("/BookStore-Project;component/bookwindow/windowbookedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BookWindow\WindowBookEdit.xaml"
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
            return;
            case 5:
            this.btn_edit = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\BookWindow\WindowBookEdit.xaml"
            this.btn_edit.Click += new System.Windows.RoutedEventHandler(this.Btn_edit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_find = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\BookWindow\WindowBookEdit.xaml"
            this.btn_find.Click += new System.Windows.RoutedEventHandler(this.Btn_find_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_back = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\BookWindow\WindowBookEdit.xaml"
            this.btn_back.Click += new System.Windows.RoutedEventHandler(this.Btn_back_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Reset = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\BookWindow\WindowBookEdit.xaml"
            this.btn_Reset.Click += new System.Windows.RoutedEventHandler(this.Btn_Reset_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tb_find = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

