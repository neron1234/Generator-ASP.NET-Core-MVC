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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Views\Shared\LayoutTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class LayoutTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Views\Shared\LayoutTemplate.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write(@"@inject Microsoft.ApplicationInsights.AspNetCore.JavaScriptSnippet JavaScriptSnippet
<!DOCTYPE html>
<html>
<head>
    <meta charset=""utf-8"" />
    <meta
        name=""viewport""
        content=""width=device-width, initial-scale=1.0"" />
    <title>@ViewData[""Title""] - ");
            
            #line 11 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Views\Shared\LayoutTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Title));
            
            #line default
            #line hidden
            this.Write("</title>\r\n    <environment names=\"Development\">\r\n        <link rel=\"stylesheet\"\r\n" +
                    "              href=\"~/lib/bootstrap/dist/css/bootstrap.css\" />\r\n        <link re" +
                    "l=\"stylesheet\"\r\n              href=\"~/css/site.css\" />\r\n    </environment>\r\n    " +
                    "<environment names=\"Staging,Production\">\r\n        <link\r\n            rel=\"styles" +
                    "heet\"\r\n            href=\"~/lib/bootstrap/dist/css/bootstrap.min.css\"\r\n          " +
                    "  asp-fallback-test-class=\"sr-only\"\r\n            asp-fallback-test-property=\"pos" +
                    "ition\"\r\n            asp-fallback-test-value=\"absolute\" />\r\n        <link\r\n      " +
                    "      rel=\"stylesheet\"\r\n            href=\"~/css/site.min.css\"\r\n            asp-a" +
                    "ppend-version=\"true\" />\r\n    </environment>\r\n    @Html.Raw(JavaScriptSnippet.Ful" +
                    "lScript)\r\n</head>\r\n<body>\r\n    <nav class=\"navbar navbar-inverse navbar-fixed-to" +
                    "p\">\r\n        <div class=\"container\">\r\n            <div class=\"navbar-header\">\r\n " +
                    "               <button\r\n                    type=\"button\"\r\n                    c" +
                    "lass=\"navbar-toggle\"\r\n                    data-toggle=\"collapse\"\r\n              " +
                    "      data-target=\".navbar-collapse\">\r\n                    <span class=\"sr-only\"" +
                    ">Toggle navigation</span>\r\n                    <span class=\"icon-bar\"></span>\r\n " +
                    "                   <span class=\"icon-bar\"></span>\r\n                    <span cla" +
                    "ss=\"icon-bar\"></span>\r\n                </button>\r\n                <a\r\n          " +
                    "          asp-area=\"\"\r\n                    asp-controller=\"GeneratorHome\"\r\n     " +
                    "               asp-action=\"Index\"\r\n                    class=\"navbar-brand\">AspN" +
                    "etCore</a>\r\n            </div>\r\n            <div class=\"navbar-collapse collapse" +
                    "\">\r\n                <ul class=\"nav navbar-nav\">\r\n                    <li><a\r\n   " +
                    "                     asp-area=\"\"\r\n                        asp-controller=\"Genera" +
                    "torHome\"\r\n                        asp-action=\"Index\">Home</a></li>\r\n            " +
                    "        <li><a\r\n                        asp-area=\"\"\r\n                        asp" +
                    "-controller=\"GeneratorHome\"\r\n                        asp-action=\"About\">About</a" +
                    "></li>\r\n                    <li><a\r\n                        asp-area=\"\"\r\n       " +
                    "                 asp-controller=\"GeneratorHome\"\r\n                        asp-act" +
                    "ion=\"Contact\">Contact</a></li>\r\n                </ul>\r\n                @await Ht" +
                    "ml.PartialAsync(\"_LoginPartial\")\r\n            </div>\r\n        </div>\r\n    </nav>" +
                    "\r\n    <div class=\"container body-content\">\r\n        @RenderBody()\r\n        <hr/>" +
                    "\r\n        <footer>\r\n            <p>&copy; 2017 - AspNetCore</p>\r\n        </foote" +
                    "r>\r\n    </div>\r\n\r\n    <environment names=\"Development\">\r\n        <script src=\"~/" +
                    "js/bundles.js\"></script>\r\n    </environment>\r\n    <environment names=\"Staging,Pr" +
                    "oduction\">\r\n        <script src=\"~/js/bundles.min.js\"></script>\r\n    </environme" +
                    "nt>\r\n\r\n    @RenderSection(\r\n        \"Scripts\",\r\n        required: false)\r\n</body" +
                    ">\r\n</html>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
