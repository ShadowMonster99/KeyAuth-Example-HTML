﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cKeyAuthExample.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("cKeyAuthExample.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///
        ///    &lt;h2&gt;Login&lt;/h2&gt;
        ///    &lt;div class=&quot;container&quot;&gt;
        ///        &lt;label for=&quot;uname&quot;&gt;&lt;b&gt;Username&lt;/b&gt;&lt;/label&gt;&lt;br /&gt;
        ///        &lt;input id=&quot;login_username&quot; type=&quot;text&quot; placeholder=&quot;Enter Username&quot; name=&quot;uname&quot; required&gt;&lt;br /&gt;
        ///
        ///        &lt;label for=&quot;psw&quot;&gt;&lt;b&gt;Password&lt;/b&gt;&lt;/label&gt;&lt;br /&gt;
        ///        &lt;input id=&quot;login_password&quot; type=&quot;password&quot; placeholder=&quot;Enter Password&quot; name=&quot;psw&quot; required&gt;&lt;br /&gt;
        ///
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string index {
            get {
                return ResourceManager.GetString("index", resourceCulture);
            }
        }
    }
}
