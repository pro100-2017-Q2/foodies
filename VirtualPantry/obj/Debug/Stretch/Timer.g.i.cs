﻿#pragma checksum "..\..\..\Stretch\Timer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CB1F076481720B0C12B5C52357847F01"
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
using VirtualPantry.Stretch;


namespace VirtualPantry.Stretch {
    
    
    /// <summary>
    /// Timer
    /// </summary>
    public partial class Timer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Hours;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.TextBox HourLabel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Button HourUpButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Button HourDownButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Seconds;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.TextBox SecondsLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Button SecondsUpButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Button SecondsDownButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressBar;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TimeLeftLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PauseButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Stretch\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopButton;
        
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
            System.Uri resourceLocater = new System.Uri("/VirtualPantry;component/stretch/timer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Stretch\Timer.xaml"
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
            this.Hours = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.HourLabel = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Stretch\Timer.xaml"
            this.HourLabel.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNum_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HourUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Stretch\Timer.xaml"
            this.HourUpButton.Click += new System.Windows.RoutedEventHandler(this.cmdUp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HourDownButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Stretch\Timer.xaml"
            this.HourDownButton.Click += new System.Windows.RoutedEventHandler(this.cmdDown_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Seconds = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.SecondsLabel = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Stretch\Timer.xaml"
            this.SecondsLabel.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNum_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SecondsUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Stretch\Timer.xaml"
            this.SecondsUpButton.Click += new System.Windows.RoutedEventHandler(this.cmdUp_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SecondsDownButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Stretch\Timer.xaml"
            this.SecondsDownButton.Click += new System.Windows.RoutedEventHandler(this.cmdDown_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 10:
            this.TimeLeftLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.StartButton = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.PauseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.StopButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

