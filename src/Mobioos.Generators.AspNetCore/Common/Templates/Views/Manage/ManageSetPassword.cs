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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Views\Manage\ManageSetPassword.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ManageSetPassword : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Views\Manage\ManageSetPassword.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("@model ");
            
            #line 3 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Views\Manage\ManageSetPassword.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Models.SetPasswordViewModel\r\n@{\r\n    ViewData[\"Title\"] = \"Set Password\";" +
                    "\r\n}\r\n\r\n<p class=\"text-info\">\r\n    You do not have a local username/password for " +
                    "this site. Add a local\r\n    account so you can log in without an external login." +
                    "\r\n</p>\r\n\r\n<form\r\n    asp-controller=\"GeneratorManage\"\r\n    asp-action=\"SetPasswo" +
                    "rd\"\r\n    asp-route-returnurl=\"@ViewData[\"ReturnUrl\"]\"\r\n    method=\"post\"\r\n    cl" +
                    "ass=\"form-horizontal\">\r\n    <h4>Set your password</h4>\r\n    <hr/>\r\n    <div\r\n   " +
                    "     asp-validation-summary=\"All\"\r\n        class=\"text-danger\"></div>\r\n    <div " +
                    "class=\"form-group\">\r\n        <label\r\n            asp-for=\"NewPassword\"\r\n        " +
                    "    class=\"col-md-2 control-label\"></label>\r\n        <div class=\"col-md-10\">\r\n  " +
                    "          <input\r\n                asp-for=\"NewPassword\"\r\n                class=\"" +
                    "form-control\" />\r\n            <span\r\n                asp-validation-for=\"NewPass" +
                    "word\"\r\n                class=\"text-danger\"></span>\r\n        </div>\r\n    </div>\r\n" +
                    "    <div class=\"form-group\">\r\n        <label\r\n            asp-for=\"ConfirmPasswo" +
                    "rd\"\r\n            class=\"col-md-2 control-label\"></label>\r\n        <div class=\"co" +
                    "l-md-10\">\r\n            <input\r\n                asp-for=\"ConfirmPassword\"\r\n      " +
                    "          class=\"form-control\" />\r\n            <span\r\n                asp-valida" +
                    "tion-for=\"ConfirmPassword\"\r\n                class=\"text-danger\"></span>\r\n       " +
                    " </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-of" +
                    "fset-2 col-md-10\">\r\n            <button\r\n                type=\"submit\"\r\n        " +
                    "        class=\"btn btn-default\">Set password</button>\r\n        </div>\r\n    </div" +
                    ">\r\n</form>\r\n\r\n@section Scripts\r\n{\r\n    @{\r\n        await Html.RenderPartialAsync" +
                    "(\"_ValidationScriptsPartial\");\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
