﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime : 15.0.0.0
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
    using Mobioos.Foundation.Jade.Extensions;
    using Mobioos.Scaffold.TextTemplating;
    using Mobioos.Generators.AspNetCore;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\DEV\Generators\Mobioos\Security\Templates\ConstantsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ConstantsTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "D:\DEV\Generators\Mobioos\Security\Templates\ConstantsTemplate.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 2 "D:\DEV\Generators\Mobioos\Security\Templates\ConstantsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(@".Backend.Helpers
{
	public static class Constants
    {
        public static class Strings
        {
            public static class JwtClaimIdentifiers
            {
                public const string Rol = ""rol"", Id = ""id"";
            }

            public static class JwtClaims
            {
                public const string ApiAccess = ""api_access"";
            }

        }
    }
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
