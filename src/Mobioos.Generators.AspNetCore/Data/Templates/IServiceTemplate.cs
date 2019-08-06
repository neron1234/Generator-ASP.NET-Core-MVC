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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class IServiceTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"

    var model = (EntityInfo)Model;
    var key = ((EntityInfo)Model).GetProperties() != null ?
        ((EntityInfo)Model)
            .GetProperties()
            .FirstOrDefault(p => p.IsKey) :
        null;

            
            #line default
            #line hidden
            this.Write("﻿using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Syst" +
                    "em.Threading.Tasks;\r\nusing ");
            
            #line 14 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels;\r\n\r\nnamespace ");
            
            #line 16 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.Services\r\n{\r\n    public interface I");
            
            #line 18 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service\r\n    {\r\n        IQueryable<");
            
            #line 20 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("> GetAll();\r\n        Task<");
            
            #line 21 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("> GetById(");
            
            #line 21 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key.CSharpType()));
            
            #line default
            #line hidden
            this.Write(" id);\r\n        Task Save(");
            
            #line 22 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(" entity);\r\n        Task Delete(");
            
            #line 23 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key.CSharpType()));
            
            #line default
            #line hidden
            this.Write(" id);\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
