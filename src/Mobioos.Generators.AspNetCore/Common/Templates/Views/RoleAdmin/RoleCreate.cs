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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Views\RoleAdmin\RoleCreate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class RoleCreate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Views\RoleAdmin\RoleCreate.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("@model ");
            
            #line 3 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Views\RoleAdmin\RoleCreate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(@".Backend.Models.RoleViewModel

@{
    ViewBag.Title = ""Create"";
}

<h2>Create new role</h2>


@using (Html.BeginForm())
{
    @Html.AntiForgeryToken()
    <div class=""form-horizontal"">
        <h4>Role.</h4>
        <hr/>
        @Html.ValidationSummary(true)

        <div class=""form-group"">
            @Html.LabelFor(model =>
                model.Name,
                new
                {
                    @class=""control-label col-md-2""
                })

            <div class=""col-md-10"">
                @Html.TextBoxFor(model =>
                    model.Name,
                    new
                    {
                        @class=""form-control""
                    })

                @Html.ValidationMessageFor(model => model.Name)
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input
                    type=""submit""
                    value=""Create""
                    class=""btn btn-default"" />
            </div>
        </div>
    </div>
}

<div>
    @Html.ActionLink(
        ""Back to List"",
        ""Index"")
</div>

@section Scripts
{
    @Scripts.Render(""~/bundles/jqueryval"")
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
