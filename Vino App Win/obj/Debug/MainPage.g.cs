﻿

#pragma checksum "c:\users\robert\documents\visual studio 2013\Projects\Vino App Win\Vino App Win\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E1061DB5C3C04567DFFF798628D631FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vino_App_Win
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 14 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).NavigationCompleted += this.Browser_NavigationCompleted;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


