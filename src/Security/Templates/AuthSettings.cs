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
    
    #line 1 "D:\DEV\Generators\Mobioos\Security\Templates\AuthSettings.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class AuthSettings : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "D:\DEV\Generators\Mobioos\Security\Templates\AuthSettings.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 2 "D:\DEV\Generators\Mobioos\Security\Templates\AuthSettings.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(@".Backend.Auth
{
	public class AuthSettings
    {
      public string FacebookAppId { get; set; }
      public string FacebookAppSecret { get; set; }
	  public string TwitterAppId { get; set; }
      public string TwitterAppSecret { get; set; }
	  public string GoogleAppId { get; set; }
      public string GoogleAppSecret { get; set; }
	  public string MicrosoftAppId { get; set; }
      public string MicrosoftAppSecret { get; set; }
    }
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
