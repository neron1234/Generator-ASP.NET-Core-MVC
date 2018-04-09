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
    
    #line 1 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class EnumTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
 var model = (EntityInfo)Model; var lastValue = model?.Values.AsEnumerable().LastOrDefault(); 
            
            #line default
            #line hidden
            this.Write("using System.Collections.Generic;\r\nusing System;\r\nusing System.ComponentModel.Dat" +
                    "aAnnotations;\r\nusing ");
            
            #line 5 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels;\r\n\r\nnamespace ");
            
            #line 7 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.");
            
            #line 7 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DataNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic enum ");
            
            #line 9 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 11 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
 if (model.Values != null) {
            
            #line default
            #line hidden
            
            #line 12 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
 foreach(var val in model.Values.AsEnumerable()) {
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 13 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(val.Id));
            
            #line default
            #line hidden
            
            #line 13 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
if(!val.Equals(lastValue)){
            
            #line default
            #line hidden
            this.Write(",");
            
            #line 13 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 14 "D:\DEV\Generators\Mobioos\Data\Templates\EnumTemplate.tt"
 } }
            
            #line default
            #line hidden
            this.Write("\t\t\r\n\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}