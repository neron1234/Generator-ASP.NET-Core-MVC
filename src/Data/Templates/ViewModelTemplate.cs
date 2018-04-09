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
    
    #line 1 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ViewModelTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 var model = (EntityInfo)Model; 
            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.ComponentModel.Dat" +
                    "aAnnotations;\r\nusing ");
            
            #line 5 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels;\r\n\r\n");
            
            #line 7 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 var lastType = ReferencedTypes.LastOrDefault(); 
            
            #line default
            #line hidden
            
            #line 8 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 var keyProperty = model.AllProperties().FirstOrDefault(p=>p.IsKey); 
            
            #line default
            #line hidden
            
            #line 9 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 var keyType = keyProperty !=null ? keyProperty.ModelProperty?.Substring(0, keyProperty.ModelProperty.IndexOf(".")) : ""; 
            
            #line default
            #line hidden
            
            #line 10 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if(string.IsNullOrEmpty(keyType)) { keyType = model.AllReferences().FirstOrDefault()?.CSharpType(); }
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 12 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.");
            
            #line 12 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ViewModelNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic partial class ");
            
            #line 14 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 14 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.BaseEntity !=null ? ": "+ model.BaseEntity.Id : ""));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n\t\tpublic ");
            
            #line 16 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("() ");
            
            #line 16 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.BaseEntity !=null ? ": base()" : ""));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t{\r\n");
            
            #line 18 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if(model.References !=null && model.References.Count() > 0) {
foreach(var reference in model.References) {
var currentReference = reference.Id; var referenceName = currentReference.First().ToString().ToUpper() + currentReference.Substring(1);
if(reference.IsCollection){ 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 22 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(referenceName));
            
            #line default
            #line hidden
            this.Write(" = new HashSet<");
            
            #line 22 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Type));
            
            #line default
            #line hidden
            this.Write(">();\r\n");
            
            #line 23 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
else{
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 25 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(referenceName));
            
            #line default
            #line hidden
            this.Write(" = new ");
            
            #line 25 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Type));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 26 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
}
}
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n");
            
            #line 31 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if (model.Properties != null){
            
            #line default
            #line hidden
            
            #line 32 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 foreach(var prop in model.Properties){ var propertyId = prop.Id.First().ToString().ToUpper() + prop.Id.Substring(1);
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 33 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.CSharpType()));
            
            #line default
            #line hidden
            
            #line 33 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.IsNullable? "?" : ""));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 33 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyId));
            
            #line default
            #line hidden
            this.Write("  { get; set; }\r\n");
            
            #line 34 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}}
            
            #line default
            #line hidden
            
            #line 35 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if(model.References !=null && model.References.Count() > 0){
foreach(var reference in model.References){
var currentReference = reference.Id; var referenceName = currentReference.First().ToString().ToUpper() + currentReference.Substring(1);
if(reference.IsCollection){ 
            
            #line default
            #line hidden
            this.Write("\t\tprivate HashSet<");
            
            #line 39 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Type));
            
            #line default
            #line hidden
            this.Write("> _");
            
            #line 39 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Id));
            
            #line default
            #line hidden
            this.Write("; \r\n\t\tprivate HashSet<");
            
            #line 40 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Type));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 40 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(referenceName));
            
            #line default
            #line hidden
            this.Write(" { get { return _");
            
            #line 40 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Id));
            
            #line default
            #line hidden
            this.Write(" ??(_");
            
            #line 40 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Id));
            
            #line default
            #line hidden
            this.Write(" = new HashSet<");
            
            #line 40 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Type));
            
            #line default
            #line hidden
            this.Write(">()); } set {  _");
            
            #line 40 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Id));
            
            #line default
            #line hidden
            this.Write(" = value; }}\r\n");
            
            #line 41 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}else{var fieldName = Char.ToLowerInvariant(reference.Id.First()) + reference.Id.Substring(1);
            
            #line default
            #line hidden
            this.Write("\t\tprivate ");
            
            #line 42 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Type));
            
            #line default
            #line hidden
            this.Write(" _");
            
            #line 42 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\tpublic virtual ");
            
            #line 43 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 43 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(referenceName));
            
            #line default
            #line hidden
            this.Write(" { get {return _");
            
            #line 43 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(";} set { _");
            
            #line 43 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(" = value;}}\r\n");
            
            #line 44 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
}
}
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 48 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if (model.BaseEntity==null) {
            
            #line default
            #line hidden
            this.Write("\t\t[Timestamp]\r\n\t\tpublic byte[] RawVersion { get; set; }\r\n");
            
            #line 51 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 53 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(" ConvertFromModel(");
            
            #line 53 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
if(ReferencedTypes.Count>0){foreach(var referencedType in ReferencedTypes){ var parameterName = Char.ToLowerInvariant(referencedType.Key[0]) + referencedType.Key.Substring(1); var modelReference = model.References.FirstOrDefault(r=>r.Type == referencedType.Key); var parameterType = modelReference != null && modelReference.IsCollection? "HashSet<"+referencedType.Key +">":referencedType.Key;
            
            #line default
            #line hidden
            
            #line 53 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 53 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterName));
            
            #line default
            #line hidden
            
            #line 53 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
if(lastType.Key!=referencedType.Key){
            
            #line default
            #line hidden
            this.Write(",");
            
            #line 53 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}}}
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n");
            
            #line 55 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
if(model.AllProperties()!=null){
            
            #line default
            #line hidden
            
            #line 56 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 foreach(var prop in model.AllProperties()) { if(!string.IsNullOrEmpty(prop.ModelProperty)) { var modelProperty = Char.ToLowerInvariant(prop.ModelProperty[0]) + prop.ModelProperty.Substring(1);var property = Char.ToUpperInvariant(prop.Id[0]) + prop.Id.Substring(1); 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 57 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 57 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(modelProperty));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 58 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}}}
            
            #line default
            #line hidden
            
            #line 59 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
foreach(var reference in model.References){var currentReference = ReferencedTypes.FirstOrDefault(r=>r.Key == reference.Type); var parameterName = Char.ToLowerInvariant(currentReference.Key[0]) + currentReference.Key.Substring(1);  var fieldName = Char.ToLowerInvariant(reference.Id[0]) + reference.Id.Substring(1);
            
            #line default
            #line hidden
            this.Write("\t\t\t_");
            
            #line 60 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 60 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 61 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\treturn this;\r\n\t\t}\r\n\r\n");
            
            #line 66 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if(ReferencedTypes != null) { 
            
            #line default
            #line hidden
            
            #line 67 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 foreach(var refType in ReferencedTypes) { var currentReferenceType = model.References.FirstOrDefault(r=>r.Type == refType.Key); var type = currentReferenceType !=null && currentReferenceType.IsCollection? "HashSet<" + refType.Key + ">": refType.Key; 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 68 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type));
            
            #line default
            #line hidden
            this.Write(" Get");
            
            #line 68 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(refType.Key));
            
            #line default
            #line hidden
            this.Write("FromViewModel()\r\n\t\t{\r\n");
            
            #line 70 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
if(model.References?.FirstOrDefault(r=>r.Type == refType.Key)!=null){var fieldName = Char.ToLowerInvariant(refType.Value[0])+refType.Value.Substring(1); 
            
            #line default
            #line hidden
            this.Write("\t\t\treturn this._");
            
            #line 71 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 72 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}else{
            
            #line default
            #line hidden
            this.Write("\t\t\tvar model = new ");
            
            #line 73 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(refType.Key));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 74 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 foreach(var prop in model.AllProperties()) { 
            
            #line default
            #line hidden
            
            #line 75 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if(!string.IsNullOrEmpty(prop.ModelProperty) && prop.ModelProperty.StartsWith(refType.Key +'.')) { 
            
            #line default
            #line hidden
            
            #line 76 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 var propertyName = prop.ModelProperty?.Split('.').Last(); var property = Char.ToUpperInvariant(prop.Id[0]) + prop.Id.Substring(1); 
            
            #line default
            #line hidden
            this.Write("\t\t\tmodel.");
            
            #line 77 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyName));
            
            #line default
            #line hidden
            this.Write(" =  ");
            
            #line 77 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 78 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 79 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\treturn model;\r\n");
            
            #line 82 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\t\t");
            
            #line 84 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 85 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 87 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if(!string.IsNullOrEmpty(keyType)) { var currentReferenceType = model.References.FirstOrDefault(r=>r.Type == keyType); var type = currentReferenceType != null && currentReferenceType.IsCollection ? "HashSet<" + keyType+ ">": keyType; 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 88 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type));
            
            #line default
            #line hidden
            this.Write(" ConvertToModel()\r\n\t\t{\r\n");
            
            #line 90 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
var currentReference = model.References?.FirstOrDefault(r=>r.Type == keyType); 
            
            #line default
            #line hidden
            
            #line 91 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
if(currentReference != null && !string.IsNullOrEmpty(currentReference.Id)){ var referenceName = currentReference.Id.First().ToString().ToUpper() + currentReference.Id.Substring(1); 
            
            #line default
            #line hidden
            this.Write("\t\t\treturn this.");
            
            #line 92 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(referenceName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 93 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}else{
            
            #line default
            #line hidden
            this.Write("\t\t\tvar model = new ");
            
            #line 94 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyType));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 95 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if (model.Properties != null) {
            
            #line default
            #line hidden
            
            #line 96 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 foreach(var prop in model.Properties) {
            
            #line default
            #line hidden
            
            #line 97 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if(!string.IsNullOrEmpty(prop.ModelProperty)) {
            
            #line default
            #line hidden
            
            #line 98 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 var modelType =  prop.ModelProperty.Substring(0, prop.ModelProperty.IndexOf("."));
            
            #line default
            #line hidden
            
            #line 99 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 if(modelType == keyType) {
            
            #line default
            #line hidden
            
            #line 100 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
 var propertyName = prop.ModelProperty.Substring(prop.ModelProperty.IndexOf(".")+1); 
            
            #line default
            #line hidden
            this.Write("\t\t\tmodel.");
            
            #line 101 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyName));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 101 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Id));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 102 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 103 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 104 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 105 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\treturn model;\r\n");
            
            #line 107 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n");
            
            #line 109 "D:\DEV\Generators\Mobioos\Data\Templates\ViewModelTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
