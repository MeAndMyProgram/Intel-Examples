﻿#pragma checksum "D:\Transporter\Transporter\__PROJECTS\IoT\_GITHUB\IoT-JumpWay-Microsoft-Examples\Intel-AI-DevJam-IDC\IDC-Classifier-GUI\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "90F789F6C17684B41805682470443F3F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDC_Classifier_GUI
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 16
                {
                    this.PreviewControl = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 2: // MainPage.xaml line 32
                {
                    this.PhotoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PhotoButton).Click += this.PhotoButton_Click;
                }
                break;
            case 3: // MainPage.xaml line 38
                {
                    this.VideoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.VideoButton).Click += this.VideoButton_Click;
                }
                break;
            case 4: // MainPage.xaml line 40
                {
                    this.StartRecordingIcon = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 5: // MainPage.xaml line 41
                {
                    this.StopRecordingIcon = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

