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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AppSettingsTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write(@"{
  ""ConnectionStrings"": {
    ""DefaultConnection"": ""Server=(localdb)\\mssqllocaldb;Database=aspnet-AspNetCore-29838208-6d0d-47f0-babd-96e19f25cb8c;Trusted_Connection=True;MultipleActiveResultSets=true""
  },
  ""Logging"": {
    ""IncludeScopes"": false,
    ""LogLevel"": {
      ""Default"": ""Warning""
    }
  },
");
            
            #line 13 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

    if (AuthenticationKeys != null)
    {

            
            #line default
            #line hidden
            this.Write("  \"AuthSettings\": {\r\n");
            
            #line 18 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

        if (AuthenticationKeys.Keys.Contains("FacebookAuthConsumerKey")
            && AuthenticationKeys.Keys.Contains("FacebookAuthConsumerSecret"))
        {

            
            #line default
            #line hidden
            this.Write("    \"FacebookAppId\": \"");
            
            #line 23 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AuthenticationKeys["FacebookAuthConsumerKey"]));
            
            #line default
            #line hidden
            this.Write("\",\r\n    \"FacebookAppSecret\": \"");
            
            #line 24 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AuthenticationKeys["FacebookAuthConsumerSecret"]));
            
            #line default
            #line hidden
            this.Write("\",\r\n");
            
            #line 25 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

        }

            
            #line default
            #line hidden
            
            #line 28 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

        if (AuthenticationKeys.Keys.Contains("TwitterAuthAppId")
            && AuthenticationKeys.Keys.Contains("TwitterAuthAppSecret"))
        {

            
            #line default
            #line hidden
            this.Write("    \"TwitterAppId\": \"");
            
            #line 33 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AuthenticationKeys["TwitterAuthAppId"]));
            
            #line default
            #line hidden
            this.Write("\",\r\n    \"TwitterAppSecret\": \"");
            
            #line 34 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AuthenticationKeys["TwitterAuthAppSecret"]));
            
            #line default
            #line hidden
            this.Write("\",\r\n");
            
            #line 35 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

        }

            
            #line default
            #line hidden
            
            #line 38 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

        if (AuthenticationKeys.Keys.Contains("GoogleAuthClientId")
            && AuthenticationKeys.Keys.Contains("GoogleAuthSecret"))
        {

            
            #line default
            #line hidden
            this.Write("    \"GoogleAppId\": \"");
            
            #line 43 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AuthenticationKeys["GoogleAuthClientId"]));
            
            #line default
            #line hidden
            this.Write("\",\r\n    \"GoogleAppSecret\": \"");
            
            #line 44 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AuthenticationKeys["GoogleAuthSecret"]));
            
            #line default
            #line hidden
            this.Write("\",\r\n");
            
            #line 45 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

        }

            
            #line default
            #line hidden
            
            #line 48 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

        if (AuthenticationKeys.Keys.Contains("MicrosoftAuthClientId")
            && AuthenticationKeys.Keys.Contains("MicrosoftAuthSecret"))
        {

            
            #line default
            #line hidden
            this.Write("    \"MicrosoftAppId\": \"");
            
            #line 53 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AuthenticationKeys["MicrosoftAuthClientId"]));
            
            #line default
            #line hidden
            this.Write("\",\r\n    \"MicrosoftAppSecret\": \"");
            
            #line 54 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AuthenticationKeys["MicrosoftAuthSecret"]));
            
            #line default
            #line hidden
            this.Write("\",\r\n");
            
            #line 55 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("  },\r\n");
            
            #line 59 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\AppSettingsTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("  \"JwtIssuerOptions\": {\r\n    \"Issuer\": \"webApi\",\r\n    \"Audience\": \"http://localho" +
                    "st:5000/\"\r\n  }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
