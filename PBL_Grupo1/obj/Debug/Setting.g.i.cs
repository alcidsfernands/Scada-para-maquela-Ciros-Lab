﻿#pragma checksum "..\..\Setting.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "574EC83589691643DB725F3888433B097A4F32228B0D238A3763A2E6D8EABE1D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

using PBL_Grupo1;
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


namespace PBL_Grupo1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Conexion;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtB_IP;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtB_Port;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Conectar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtB_Hex;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Proceso;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse luz_marcha;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse luz_paro;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse luz_rearme;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Setting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Salir;
        
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
            System.Uri resourceLocater = new System.Uri("/PBL_Grupo1;component/setting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Setting.xaml"
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
            this.tabControl1 = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.Conexion = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.txtB_IP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtB_Port = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_Conectar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Setting.xaml"
            this.btn_Conectar.Click += new System.Windows.RoutedEventHandler(this.btn_Conectar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtB_Hex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Proceso = ((System.Windows.Controls.TabItem)(target));
            return;
            case 8:
            this.luz_marcha = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 9:
            this.luz_paro = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 10:
            this.luz_rearme = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 11:
            this.btn_Salir = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\Setting.xaml"
            this.btn_Salir.Click += new System.Windows.RoutedEventHandler(this.btn_Salir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
