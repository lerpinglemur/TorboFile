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
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CustomSearchStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CustomSearchStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TorboFile.Properties.CustomSearchStrings", typeof(CustomSearchStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exclude Matches.
        /// </summary>
        public static string exclude_option {
            get {
                return ResourceManager.GetString("exclude_option", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If checked, only items that do NOT match this requirement will be included in results..
        /// </summary>
        public static string exclude_tip {
            get {
                return ResourceManager.GetString("exclude_tip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only directories will be included in the search results..
        /// </summary>
        public static string is_file_exclude {
            get {
                return ResourceManager.GetString("is_file_exclude", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directories will be excluded from the search results..
        /// </summary>
        public static string is_file_include {
            get {
                return ResourceManager.GetString("is_file_include", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max Files:.
        /// </summary>
        public static string match_count_max_prompt {
            get {
                return ResourceManager.GetString("match_count_max_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directories containing more files will not be matched.&quot;.
        /// </summary>
        public static string match_count_max_tip {
            get {
                return ResourceManager.GetString("match_count_max_tip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Min Files:.
        /// </summary>
        public static string match_count_min_prompt {
            get {
                return ResourceManager.GetString("match_count_min_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directories containing fewer files will not be matched..
        /// </summary>
        public static string match_count_min_tip {
            get {
                return ResourceManager.GetString("match_count_min_tip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Match directories which contain a given number of sub-files.&amp;#x0a;Files are also matched, unless a Directory-Only condition is added..
        /// </summary>
        public static string match_count_prompt {
            get {
                return ResourceManager.GetString("match_count_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subdirectories count against total..
        /// </summary>
        public static string match_count_subdir_opt {
            get {
                return ResourceManager.GetString("match_count_subdir_opt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty directories will be excluded from the search..
        /// </summary>
        public static string match_empty_dir_exclude {
            get {
                return ResourceManager.GetString("match_empty_dir_exclude", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty directories will be included in the search..
        /// </summary>
        public static string match_empty_dir_include {
            get {
                return ResourceManager.GetString("match_empty_dir_include", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty Directories.
        /// </summary>
        public static string match_empty_dir_title {
            get {
                return ResourceManager.GetString("match_empty_dir_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allowed File Extensions:.
        /// </summary>
        public static string match_ext_prompt {
            get {
                return ResourceManager.GetString("match_ext_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Separate extensions with &apos;;&apos; or &apos;,&apos;.
        /// </summary>
        public static string match_ext_tip {
            get {
                return ResourceManager.GetString("match_ext_tip", resourceCulture);
            }
        }
    }
}
