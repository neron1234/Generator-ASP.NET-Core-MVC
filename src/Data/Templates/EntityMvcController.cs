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
    using Mobioos.Scaffold.BaseGenerators.TextTemplating;
    using Mobioos.Generators.AspNetCore;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class EntityMvcController : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
 var model = (EntityInfo)Model; var key = ((EntityInfo)Model).AllProperties() != null ? ((EntityInfo)Model).AllProperties().FirstOrDefault(p=>p.IsKey) : null; 
            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Syste" +
                    "m.Threading.Tasks;\r\nusing Microsoft.AspNetCore.Authorization;\r\nusing Microsoft.E" +
                    "ntityFrameworkCore;\r\nusing Microsoft.AspNetCore.Mvc;\r\nusing ");
            
            #line 9 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels;\r\nusing ");
            
            #line 10 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.Controllers;\r\nusing ");
            
            #line 11 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.Models;\r\nusing ");
            
            #line 12 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.Services;\r\n\r\n\r\nnamespace ");
            
            #line 15 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.Controllers\r\n{\r\n    public partial class ");
            
            #line 17 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Controller : ControllerBase<");
            
            #line 17 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n\r\n        private I");
            
            #line 20 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service _");
            
            #line 20 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service;\r\n\r\n        public ");
            
            #line 22 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Controller(I");
            
            #line 22 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service ");
            
            #line 22 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service)\r\n        {\r\n\t\t\t_");
            
            #line 24 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service = ");
            
            #line 24 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service;\r\n        }\r\n\t\r\n\t\t");
            
            #line 27 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
var properties = model.Properties != null ? string.Join(",",model.Properties.Select(p=>p.Id).ToArray()) + ",RawVersion" : ""; 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t// GET: ");
            
            #line 29 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("\r\n        public async Task<IActionResult> Index()\r\n        {\r\n            return" +
                    " View((_");
            
            #line 32 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service.GetAll()).AsQueryable());\r\n        }\r\n\r\n\r\n\t\t// GET:");
            
            #line 36 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("/Details/5\r\n        public async Task<IActionResult> Details(");
            
            #line 37 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key.CSharpType()));
            
            #line default
            #line hidden
            this.Write(" id)\r\n        {\r\n            var entity = await _");
            
            #line 39 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(@"Service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }        

        // GET: <entity>/Create
        public IActionResult Create()
        {
            return View();
        }

		

		// POST: ");
            
            #line 55 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(@"/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async  Task<IActionResult> Create([Bind(""");
            
            #line 60 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(properties));
            
            #line default
            #line hidden
            this.Write("\")] ");
            
            #line 60 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(" entity)\r\n        {\r\n            if (ModelState.IsValid)\r\n            {\r\n        " +
                    "        await _");
            
            #line 64 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service.Save(entity);\r\n                return RedirectToAction(\"Index\");\r\n       " +
                    "     }\r\n\r\n            return View(entity);\r\n        }\r\n      \r\n\t\t// GET: ");
            
            #line 71 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("/Edit/5\r\n        public async Task<IActionResult> Edit(");
            
            #line 72 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key.CSharpType()));
            
            #line default
            #line hidden
            this.Write(" id)\r\n        {\r\n            var entity = await _");
            
            #line 74 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service.GetById(id);\r\n            if (entity == null)\r\n            {\r\n           " +
                    "     return NotFound();\r\n            }\r\n            return View(entity);\r\n      " +
                    "  }\r\n\r\n\t\t// POST: ");
            
            #line 82 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(@"/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Edit([Bind(""");
            
            #line 87 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(properties));
            
            #line default
            #line hidden
            this.Write("\")] ");
            
            #line 87 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(" entity)\r\n        {\r\n            if (ModelState.IsValid)\r\n            {\r\n        " +
                    "        await _");
            
            #line 91 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service.Save(entity);\r\n                return RedirectToAction(\"Index\");\r\n       " +
                    "     }\r\n            return View(entity);\r\n        }\r\n\r\n\r\n\t\t // GET: ");
            
            #line 98 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("/Delete/5\r\n        public async Task<IActionResult> Delete(");
            
            #line 99 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key.CSharpType()));
            
            #line default
            #line hidden
            this.Write(" id)\r\n        {\r\n            var entity = await _");
            
            #line 101 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service.GetById(id);\r\n            if (entity == null)\r\n            {\r\n           " +
                    "     return NotFound();\r\n            }\r\n            return View(entity);\r\n      " +
                    "  }\r\n\r\n        // POST: ");
            
            #line 109 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("/Delete/5\r\n        [HttpPost, ActionName(\"Delete\")]\r\n        [ValidateAntiForgery" +
                    "Token]\r\n        public async Task<IActionResult> DeleteConfirmed(");
            
            #line 112 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key.CSharpType()));
            
            #line default
            #line hidden
            this.Write(" id)\r\n        {\r\n            await _");
            
            #line 114 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\EntityMvcController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service.Delete(id);\r\n            return RedirectToAction(\"Index\");\r\n        }\r\n  " +
                    "  }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
