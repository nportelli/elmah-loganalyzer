﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.530
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElmahLogAnalyzer.Core.Domain.Export {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DatabaseScripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DatabaseScripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ElmahLogAnalyzer.Core.Domain.Export.DatabaseScripts", typeof(DatabaseScripts).Assembly);
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
        ///   Looks up a localized string similar to ALTER TABLE [ClientInformation]
        ///ADD CONSTRAINT [FK_ClientInformation_ErrorLog]
        ///FOREIGN KEY (ErrorLogId) REFERENCES ErrorLogs(ErrorId).
        /// </summary>
        internal static string SqlCeDatabaseSchemaClientInformationForeignKeys {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaClientInformationForeignKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [ClientInformation](
        ///	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
        ///	[Browser][nvarchar](256) NULL,
        ///	[OperatingSystem] [nvarchar](256) NULL,
        ///	[Platform] [nvarchar](256) NULL,
        ///	[Description] [nvarchar](256) NULL,
        ///	[ErrorLogId] [uniqueidentifier] NOT NULL
        ///).
        /// </summary>
        internal static string SqlCeDatabaseSchemaClientInformationTable {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaClientInformationTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE [CookieValues]
        ///ADD CONSTRAINT [FK_CookieValue_ErrorLog]
        ///FOREIGN KEY (ErrorLogId) REFERENCES ErrorLogs(ErrorId).
        /// </summary>
        internal static string SqlCeDatabaseSchemaCookieValuesForeignKeys {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaCookieValuesForeignKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [CookieValues](
        ///	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
        ///	[Name][nvarchar](4000) NULL,
        ///	[Value] [nvarchar](4000) NULL,
        ///	[ErrorLogId] [uniqueidentifier] NOT NULL
        ///).
        /// </summary>
        internal static string SqlCeDatabaseSchemaCookieValuesTable {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaCookieValuesTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [ErrorLogs](
        ///	[ErrorId] [uniqueidentifier]  PRIMARY KEY NOT NULL,
        ///	[Application][nvarchar](4000) NULL,
        ///	[Host] [nvarchar](4000) NULL, 
        ///	[Type] [nvarchar](4000) NULL,
        ///	[Message] [nvarchar](4000) NULL,
        ///	[Source] [nvarchar](4000) NULL,
        ///	[Details] [ntext] NULL,
        ///	[Time] [datetime] NULL,
        ///	[StatusCode] [nvarchar](50) NULL,
        ///	[User] [nvarchar](256) NULL,
        ///	[Url] [nvarchar](4000) NULL)
        ///.
        /// </summary>
        internal static string SqlCeDatabaseSchemaErrorLogsTable {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaErrorLogsTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE [FormValues]
        ///ADD CONSTRAINT [FK_FormValue_ErrorLog]
        ///FOREIGN KEY (ErrorLogId) REFERENCES ErrorLogs(ErrorId);
        ///.
        /// </summary>
        internal static string SqlCeDatabaseSchemaFormValuesForeignKeys {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaFormValuesForeignKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [FormValues](
        ///	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
        ///	[Name][nvarchar](4000) NULL,
        ///	[Value] [nvarchar](4000) NULL,
        ///	[ErrorLogId] [uniqueidentifier] NOT NULL
        ///).
        /// </summary>
        internal static string SqlCeDatabaseSchemaFormValuesTable {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaFormValuesTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE [QuerystringValues]
        ///ADD CONSTRAINT [FK_QuerystringValue_ErrorLog]
        ///FOREIGN KEY (ErrorLogId) REFERENCES ErrorLogs(ErrorId).
        /// </summary>
        internal static string SqlCeDatabaseSchemaQuerystringValuesForeignKeys {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaQuerystringValuesForeignKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [QuerystringValues](
        ///	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
        ///	[Name][nvarchar](4000) NULL,
        ///	[Value] [nvarchar](4000) NULL,
        ///	[ErrorLogId] [uniqueidentifier] NOT NULL
        ///).
        /// </summary>
        internal static string SqlCeDatabaseSchemaQuerystringValuesTable {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaQuerystringValuesTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE [ServerInformation]
        ///ADD CONSTRAINT [FK_ServerInformation_ErrorLog]
        ///FOREIGN KEY (ErrorLogId) REFERENCES ErrorLogs(ErrorId).
        /// </summary>
        internal static string SqlCeDatabaseSchemaServerInformationForeignKeys {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaServerInformationForeignKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [ServerInformation](
        ///	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
        ///	[Host][nvarchar](256) NULL,
        ///	[Name] [nvarchar](500) NULL,
        ///	[Port] [nvarchar](256) NULL,
        ///	[Software] [nvarchar](256) NULL,
        ///	[ErrorLogId] [uniqueidentifier] NOT NULL).
        /// </summary>
        internal static string SqlCeDatabaseSchemaServerInformationTable {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaServerInformationTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE [ServerVariables]
        ///ADD CONSTRAINT [FK_ServerVariable_ErrorLog]
        ///FOREIGN KEY (ErrorLogId) REFERENCES ErrorLogs(ErrorId).
        /// </summary>
        internal static string SqlCeDatabaseSchemaServerVariablesForeignKeys {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaServerVariablesForeignKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [ServerVariables](
        ///	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
        ///	[Name][nvarchar](4000) NULL,
        ///	[Value] [nvarchar](4000) NULL,
        ///	[ErrorLogId] [uniqueidentifier] NOT NULL
        ///).
        /// </summary>
        internal static string SqlCeDatabaseSchemaServerVariablesTable {
            get {
                return ResourceManager.GetString("SqlCeDatabaseSchemaServerVariablesTable", resourceCulture);
            }
        }
    }
}
