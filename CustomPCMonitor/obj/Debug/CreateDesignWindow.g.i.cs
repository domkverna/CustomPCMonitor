﻿#pragma checksum "..\..\CreateDesignWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8F8B5FB2DBD0158468FED52AC89FFC7265FF22573551437E0C690E12C230DA4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CustomPCMonitor;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace CustomPCMonitor {
    
    
    /// <summary>
    /// CreateDesignWindow
    /// </summary>
    public partial class CreateDesignWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\CreateDesignWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CustomTitleBar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\CreateDesignWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox widthTextBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\CreateDesignWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox heightTextBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\CreateDesignWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border StartBorder;
        
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
            System.Uri resourceLocater = new System.Uri("/CustomPCMonitor;component/createdesignwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateDesignWindow.xaml"
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
            this.CustomTitleBar = ((System.Windows.Controls.Grid)(target));
            
            #line 18 "..\..\CreateDesignWindow.xaml"
            this.CustomTitleBar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CustomTitleBar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 34 "..\..\CreateDesignWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Minimize_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 48 "..\..\CreateDesignWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.widthTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\CreateDesignWindow.xaml"
            this.widthTextBox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ClearTextboxOnClick);
            
            #line default
            #line hidden
            
            #line 65 "..\..\CreateDesignWindow.xaml"
            this.widthTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 66 "..\..\CreateDesignWindow.xaml"
            this.widthTextBox.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.NumericTextBox_Pasting));
            
            #line default
            #line hidden
            return;
            case 5:
            this.heightTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\CreateDesignWindow.xaml"
            this.heightTextBox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ClearTextboxOnClick);
            
            #line default
            #line hidden
            
            #line 82 "..\..\CreateDesignWindow.xaml"
            this.heightTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 83 "..\..\CreateDesignWindow.xaml"
            this.heightTextBox.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.NumericTextBox_Pasting));
            
            #line default
            #line hidden
            return;
            case 6:
            this.StartBorder = ((System.Windows.Controls.Border)(target));
            
            #line 97 "..\..\CreateDesignWindow.xaml"
            this.StartBorder.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ApplyCanvasSize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

