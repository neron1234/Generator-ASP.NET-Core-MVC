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
    
    #line 1 "D:\DEV\Generators\Mobioos\Common\Templates\Views\Manage\ManageVerifyPhoneNumber.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ManageVerifyPhoneNumber : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "D:\DEV\Generators\Mobioos\Common\Templates\Views\Manage\ManageVerifyPhoneNumber.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("@model ");
            
            #line 2 "D:\DEV\Generators\Mobioos\Common\Templates\Views\Manage\ManageVerifyPhoneNumber.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(@".Backend.Models.VerifyPhoneNumberViewModel
@{
    ViewData[""Title""] = ""Verify Phone Number"";
}

<h2>@ViewData[""Title""].</h2>

<form asp-controller=""Manage"" asp-action=""VerifyPhoneNumber"" asp-route-returnurl=""@ViewData[""ReturnUrl""]"" method=""post"" class=""form-horizontal"">
    <input asp-for=""PhoneNumber"" type=""hidden"" />
    <h4>Add a phone number.</h4>
    <h5>@ViewData[""Status""]</h5>
    <hr />
    <div asp-validation-summary=""All"" class=""text-danger""></div>
    <div class=""form-group"">
        <label asp-for=""Code"" class=""col-md-2 control-label""></label>
        <div class=""col-md-10"">
            <input asp-for=""Code"" class=""form-control"" />
            <span asp-validation-for=""Code"" class=""text-danger""></span>
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
            <button type=""submit"" class=""btn btn-default"">Submit</button>
        </div>
    </div>
</form>

@section Scripts {
    @{ await Html.RenderPartialAsync(""_ValidationScriptsPartial""); }
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
