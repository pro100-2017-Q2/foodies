﻿#pragma checksum "..\..\..\Pantry\AddEditPantryItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C38CAD1A39F11EE01E68E3F853EF3E68"
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
using VirtualPantry.Pantry;


namespace VirtualPantry.Pantry {
    
    
    /// <summary>
    /// AddEditPantryItem
    /// </summary>
    public partial class AddEditPantryItem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pantry\AddEditPantryItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Title;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pantry\AddEditPantryItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Category;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pantry\AddEditPantryItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Units;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pantry\AddEditPantryItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WholeNumber;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pantry\AddEditPantryItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Numerator;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Pantry\AddEditPantryItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Denominator;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Pantry\AddEditPantryItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Pantry\AddEditPantryItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/VirtualPantry;component/pantry/addeditpantryitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pantry\AddEditPantryItem.xaml"
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
            this.Title = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Category = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Units = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.WholeNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Numerator = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Denominator = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\Pantry\AddEditPantryItem.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.AddPantryItemButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\Pantry\AddEditPantryItem.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

