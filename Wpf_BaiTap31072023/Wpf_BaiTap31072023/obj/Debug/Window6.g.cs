﻿#pragma checksum "..\..\Window6.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "711A5953C67E19F86A8A9432BC9BEB208BDFE81A69B45836A6BC0E81CCD6BBF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Wpf_BaiTap31072023;


namespace Wpf_BaiTap31072023 {
    
    
    /// <summary>
    /// Window6
    /// </summary>
    public partial class Window6 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkCoffee;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkKiwiJuice;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkTaTua;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_BaiTap31072023;component/window6.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window6.xaml"
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
            this.listBox1 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.chkCoffee = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\Window6.xaml"
            this.chkCoffee.Checked += new System.Windows.RoutedEventHandler(this.HandleChecked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\Window6.xaml"
            this.chkCoffee.Unchecked += new System.Windows.RoutedEventHandler(this.HandleUnchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chkKiwiJuice = ((System.Windows.Controls.CheckBox)(target));
            
            #line 32 "..\..\Window6.xaml"
            this.chkKiwiJuice.Checked += new System.Windows.RoutedEventHandler(this.HandleChecked);
            
            #line default
            #line hidden
            
            #line 33 "..\..\Window6.xaml"
            this.chkKiwiJuice.Unchecked += new System.Windows.RoutedEventHandler(this.HandleUnchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chkTaTua = ((System.Windows.Controls.CheckBox)(target));
            
            #line 42 "..\..\Window6.xaml"
            this.chkTaTua.Checked += new System.Windows.RoutedEventHandler(this.HandleChecked);
            
            #line default
            #line hidden
            
            #line 43 "..\..\Window6.xaml"
            this.chkTaTua.Unchecked += new System.Windows.RoutedEventHandler(this.HandleUnchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 54 "..\..\Window6.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DislayCustomerChoices);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
