﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMTPTest.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("smtp.gmail.com")]
        public string MailSMTP {
            get {
                return ((string)(this["MailSMTP"]));
            }
            set {
                this["MailSMTP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("587")]
        public int MailSMTPPort {
            get {
                return ((int)(this["MailSMTPPort"]));
            }
            set {
                this["MailSMTPPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MailSMTPSSL {
            get {
                return ((bool)(this["MailSMTPSSL"]));
            }
            set {
                this["MailSMTPSSL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MailAccountAddress {
            get {
                return ((string)(this["MailAccountAddress"]));
            }
            set {
                this["MailAccountAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MailPassword {
            get {
                return ((string)(this["MailPassword"]));
            }
            set {
                this["MailPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MailTestAddress {
            get {
                return ((string)(this["MailTestAddress"]));
            }
            set {
                this["MailTestAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Test Subject")]
        public string MailSubject {
            get {
                return ((string)(this["MailSubject"]));
            }
            set {
                this["MailSubject"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CCMail {
            get {
                return ((string)(this["CCMail"]));
            }
            set {
                this["CCMail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"          <!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
          <html xmlns=""http://www.w3.org/1999/xhtml"">
          <head>
          <title></title>
          <style type=""text/css"">
          body
          {
          font-family: Arial;
          font-size: 10pt;
          padding: 0;
          margin: 0;
          color: #000000;
          }
          a:link
          {
          color: Blue;
          }
          a:visited
          {
          color: Blue;
          }
          a:hover
          {
          color: Red;
          }
          a:active
          {
          color: Red;
          }
          </style>
          </head>
          <body>
          <div>
          <p>
          Dear {USER},</p>
          <p>
          You are receiving this email to notify you that there our OTI indicator has detected
          a change in trend of your stock {TICKER}. Please log in to you account at the HCM
          401(k) Optimizer® <a href=""http://www.hcm401koptimizer.com/OTI.aspx"">www.hcm401koptimizer.com/OTI.aspx</a>
          to see it.
          </p>
          <p>
          Aroon value is {AROON}
          </p>
          <p>
          Regards,
          <br />
          The HCM 401(k) Optimizer® team
          </p>
          </div>
          </body>
          </html>")]
        public string MailPattern {
            get {
                return ((string)(this["MailPattern"]));
            }
            set {
                this["MailPattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EmailFrom {
            get {
                return ((string)(this["EmailFrom"]));
            }
            set {
                this["EmailFrom"] = value;
            }
        }
    }
}