﻿

#pragma checksum "C:\Users\wisani\Desktop\game woring on\update\Dictionary_Game _App\Dictionary_Game _App\Dictionary_Game _App.Shared\Games\GamePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B7A7329BAA880521E516F0CB088E5BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dictionary_Game_App.Games
{
    partial class GamePage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 18 "..\..\..\Games\GamePage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.txtSearch_TextChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 19 "..\..\..\Games\GamePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnBack_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 48 "..\..\..\Games\GamePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.radSearchEnglishWord_Checked;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 49 "..\..\..\Games\GamePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.btnSearchOtherLangWord_Checked_1;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 50 "..\..\..\Games\GamePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.combLanguage_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 51 "..\..\..\Games\GamePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnPlay_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 59 "..\..\..\Games\GamePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.radEasy_Game_Checked;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 60 "..\..\..\Games\GamePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.radHard_Game_Checked;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 64 "..\..\..\Games\GamePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnViewHighScore_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


