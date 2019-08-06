﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime : 16.0.0.0
//  
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Mobioos.Generators.AspNetCore
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Mobioos.Foundation.Jade.Models;
    using Mobioos.Scaffold.BaseGenerators.TextTemplating;
    using Common.Generator.Framework.Extensions;
    using Mobioos.Generators.AspNetCore;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\ServiceContext.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ServiceContext : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\ServiceContext.tt"

    var model = (SmartAppInfo)Model;
    var models = model.GetModels();

            
            #line default
            #line hidden
            this.Write("using System.Linq;\r\nusing Microsoft.EntityFrameworkCore;\r\nusing ");
            
            #line 8 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\ServiceContext.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels;\r\n\r\nnamespace ");
            
            #line 10 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\ServiceContext.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Models\r\n{\r\n    public partial class MobileServiceContext : DbContext\r\n  " +
                    "  {\r\n        // You can add custom code to this file. Changes will not be overwr" +
                    "itten.\r\n        //\r\n        // If you want Entity Framework to alter your databa" +
                    "se\r\n        // automatically whenever you change your model schema, please use d" +
                    "ata migrations.\r\n        // For more information refer to the documentation:\r\n  " +
                    "      // http://msdn.microsoft.com/en-us/data/jj591621.aspx\r\n        //\r\n       " +
                    " // To enable Entity Framework migrations in the cloud, please ensure that the\r\n" +
                    "        // service name, set by the \'MS_MobileServiceName\' AppSettings in the lo" +
                    "cal\r\n        // Web.config, is the same as the service name when hosted in Azure" +
                    ".\r\n\r\n        private const string connectionStringName = \"Name=MS_TableConnectio" +
                    "nString\";\r\n\r\n        public MobileServiceContext()\r\n            : base(connectio" +
                    "nStringName)\r\n        {\r\n        }\r\n\r\n        protected override void OnModelCre" +
                    "ating(DbModelBuilder modelBuilder)\r\n        {\r\n            /*\r\n            strin" +
                    "g schema = ServiceSettingsDictionary.GetSchemaName();\r\n\r\n            if (!string" +
                    ".IsNullOrEmpty(schema))\r\n            {\r\n                modelBuilder.HasDefaultS" +
                    "chema(schema);\r\n            }\r\n\r\n            modelBuilder.Conventions.Add(\r\n    " +
                    "            new AttributeToColumnAnnotationConvention<TableColumnAttribute, stri" +
                    "ng>(\r\n                    \"ServiceTableColumn\",\r\n                    (property, " +
                    "attributes) =>\r\n                        attributes\r\n                            " +
                    ".Single()\r\n                            .ColumnType\r\n                            " +
                    ".ToString()));\r\n            */\r\n        }\r\n");
            
            #line 52 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\ServiceContext.tt"

    if (models != null)
    {

        foreach (var entity in models)
        {

            
            #line default
            #line hidden
            this.Write("        public DbSet<");
            
            #line 59 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\ServiceContext.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Id));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 59 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\ServiceContext.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Id));
            
            #line default
            #line hidden
            this.Write("s { get; set; }\r\n");
            
            #line 60 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\ServiceContext.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
