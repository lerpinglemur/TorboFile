﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TorboFile.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class CustomSearchSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static CustomSearchSettings defaultInstance = ((CustomSearchSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new CustomSearchSettings())));
        
        public static CustomSearchSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string lastDirectory {
            get {
                return ((string)(this["lastDirectory"]));
            }
            set {
                this["lastDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool saveLastDirectory {
            get {
                return ((bool)(this["saveLastDirectory"]));
            }
            set {
                this["saveLastDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool saveLastSearch {
            get {
                return ((bool)(this["saveLastSearch"]));
            }
            set {
                this["saveLastSearch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::TorboFile.Model.CustomSearchFlags searchFlags {
            get {
                return ((global::TorboFile.Model.CustomSearchFlags)(this["searchFlags"]));
            }
            set {
                this["searchFlags"] = value;
            }
        }
    }
}
