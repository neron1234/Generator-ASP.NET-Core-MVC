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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class EnumTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"

    var model = (EntityInfo)Model;

    var lastValue = model?
        .Values
        .LastOrDefault();

            
            #line default
            #line hidden
            this.Write("using System.Collections.Generic;\r\nusing System;\r\nusing System.ComponentModel.Dat" +
                    "aAnnotations;\r\nusing ");
            
            #line 12 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels;\r\n\r\nnamespace ");
            
            #line 14 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.");
            
            #line 14 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DataNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public enum ");
            
            #line 16 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n");
            
            #line 18 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"

    if (model.Values != null)
    {
        foreach (var val in model.Values)
        {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 24 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(val.Id));
            
            #line default
            #line hidden
            
            #line 24 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!val.Equals(lastValue) ? "," : ""));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 25 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\EnumTemplate.tt"

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
