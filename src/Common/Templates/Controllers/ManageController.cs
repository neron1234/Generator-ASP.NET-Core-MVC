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
    
    #line 1 "D:\DEV\Generators\Mobioos\Common\Templates\Controllers\ManageController.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ManageController : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "D:\DEV\Generators\Mobioos\Common\Templates\Controllers\ManageController.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write(@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ");
            
            #line 10 "D:\DEV\Generators\Mobioos\Common\Templates\Controllers\ManageController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Services;\r\nusing ");
            
            #line 11 "D:\DEV\Generators\Mobioos\Common\Templates\Controllers\ManageController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Infrastructure.Services;\r\nusing ");
            
            #line 12 "D:\DEV\Generators\Mobioos\Common\Templates\Controllers\ManageController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Models;\r\n\r\nnamespace ");
            
            #line 14 "D:\DEV\Generators\Mobioos\Common\Templates\Controllers\ManageController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Controllers\r\n{\r\n    [Authorize]\r\n    public partial class ManageControll" +
                    "er : Controller\r\n    {\r\n        private readonly UserManager<ApplicationUser> _u" +
                    "serManager;\r\n        private readonly SignInManager<ApplicationUser> _signInMana" +
                    "ger;\r\n        private readonly IEmailSender _emailSender;\r\n        private reado" +
                    "nly ISmsSender _smsSender;\r\n        private readonly ILogger _logger;\r\n\r\n       " +
                    " public ManageController(\r\n        UserManager<ApplicationUser> userManager,\r\n  " +
                    "      SignInManager<ApplicationUser> signInManager,\r\n        IEmailSender emailS" +
                    "ender,\r\n        ISmsSender smsSender,\r\n        ILoggerFactory loggerFactory)\r\n  " +
                    "      {\r\n            _userManager = userManager;\r\n            _signInManager = s" +
                    "ignInManager;\r\n            _emailSender = emailSender;\r\n            _smsSender =" +
                    " smsSender;\r\n            _logger = loggerFactory.CreateLogger<ManageController>(" +
                    ");\r\n        }\r\n\r\n        //\r\n        // GET: /Manage/Index\r\n        [HttpGet]\r\n " +
                    "       public async Task<IActionResult> Index(ManageMessageId? message = null)\r\n" +
                    "        {\r\n            ViewData[\"StatusMessage\"] =\r\n                message == M" +
                    "anageMessageId.ChangePasswordSuccess ? \"Your password has been changed.\"\r\n      " +
                    "          : message == ManageMessageId.SetPasswordSuccess ? \"Your password has b" +
                    "een set.\"\r\n                : message == ManageMessageId.SetTwoFactorSuccess ? \"Y" +
                    "our two-factor authentication provider has been set.\"\r\n                : message" +
                    " == ManageMessageId.Error ? \"An error has occurred.\"\r\n                : message " +
                    "== ManageMessageId.AddPhoneSuccess ? \"Your phone number was added.\"\r\n           " +
                    "     : message == ManageMessageId.RemovePhoneSuccess ? \"Your phone number was re" +
                    "moved.\"\r\n                : \"\";\r\n\r\n            var user = await GetCurrentUserAsy" +
                    "nc();\r\n            if (user == null)\r\n            {\r\n                return View" +
                    "(\"Error\");\r\n            }\r\n            var model = new IndexViewModel\r\n         " +
                    "   {\r\n                HasPassword = await _userManager.HasPasswordAsync(user),\r\n" +
                    "                PhoneNumber = await _userManager.GetPhoneNumberAsync(user),\r\n   " +
                    "             TwoFactor = await _userManager.GetTwoFactorEnabledAsync(user),\r\n   " +
                    "             Logins = await _userManager.GetLoginsAsync(user),\r\n                " +
                    "BrowserRemembered = await _signInManager.IsTwoFactorClientRememberedAsync(user)\r" +
                    "\n            };\r\n            return View(model);\r\n        }\r\n\r\n        //\r\n     " +
                    "   // POST: /Manage/RemoveLogin\r\n        [HttpPost]\r\n        [ValidateAntiForger" +
                    "yToken]\r\n        public async Task<IActionResult> RemoveLogin(RemoveLoginViewMod" +
                    "el account)\r\n        {\r\n            ManageMessageId? message = ManageMessageId.E" +
                    "rror;\r\n            var user = await GetCurrentUserAsync();\r\n            if (user" +
                    " != null)\r\n            {\r\n                var result = await _userManager.Remove" +
                    "LoginAsync(user, account.LoginProvider, account.ProviderKey);\r\n                i" +
                    "f (result.Succeeded)\r\n                {\r\n                    await _signInManage" +
                    "r.SignInAsync(user, isPersistent: false);\r\n                    message = ManageM" +
                    "essageId.RemoveLoginSuccess;\r\n                }\r\n            }\r\n            retu" +
                    "rn RedirectToAction(nameof(ManageLogins), new { Message = message });\r\n        }" +
                    "\r\n\r\n        //\r\n        // GET: /Manage/AddPhoneNumber\r\n        public IActionRe" +
                    "sult AddPhoneNumber()\r\n        {\r\n            return View();\r\n        }\r\n\r\n     " +
                    "   //\r\n        // POST: /Manage/AddPhoneNumber\r\n        [HttpPost]\r\n        [Val" +
                    "idateAntiForgeryToken]\r\n        public async Task<IActionResult> AddPhoneNumber(" +
                    "AddPhoneNumberViewModel model)\r\n        {\r\n            if (!ModelState.IsValid)\r" +
                    "\n            {\r\n                return View(model);\r\n            }\r\n            " +
                    "// Generate the token and send it\r\n            var user = await GetCurrentUserAs" +
                    "ync();\r\n            if (user == null)\r\n            {\r\n                return Vie" +
                    "w(\"Error\");\r\n            }\r\n            var code = await _userManager.GenerateCh" +
                    "angePhoneNumberTokenAsync(user, model.PhoneNumber);\r\n            await _smsSende" +
                    "r.SendSmsAsync(model.PhoneNumber, \"Your security code is: \" + code);\r\n          " +
                    "  return RedirectToAction(nameof(VerifyPhoneNumber), new { PhoneNumber = model.P" +
                    "honeNumber });\r\n        }\r\n\r\n        //\r\n        // POST: /Manage/EnableTwoFacto" +
                    "rAuthentication\r\n        [HttpPost]\r\n        [ValidateAntiForgeryToken]\r\n       " +
                    " public async Task<IActionResult> EnableTwoFactorAuthentication()\r\n        {\r\n  " +
                    "          var user = await GetCurrentUserAsync();\r\n            if (user != null)" +
                    "\r\n            {\r\n                await _userManager.SetTwoFactorEnabledAsync(use" +
                    "r, true);\r\n                await _signInManager.SignInAsync(user, isPersistent: " +
                    "false);\r\n                _logger.LogInformation(1, \"User enabled two-factor auth" +
                    "entication.\");\r\n            }\r\n            return RedirectToAction(nameof(Index)" +
                    ", \"Manage\");\r\n        }\r\n\r\n        //\r\n        // POST: /Manage/DisableTwoFactor" +
                    "Authentication\r\n        [HttpPost]\r\n        [ValidateAntiForgeryToken]\r\n        " +
                    "public async Task<IActionResult> DisableTwoFactorAuthentication()\r\n        {\r\n  " +
                    "          var user = await GetCurrentUserAsync();\r\n            if (user != null)" +
                    "\r\n            {\r\n                await _userManager.SetTwoFactorEnabledAsync(use" +
                    "r, false);\r\n                await _signInManager.SignInAsync(user, isPersistent:" +
                    " false);\r\n                _logger.LogInformation(2, \"User disabled two-factor au" +
                    "thentication.\");\r\n            }\r\n            return RedirectToAction(nameof(Inde" +
                    "x), \"Manage\");\r\n        }\r\n\r\n        //\r\n        // GET: /Manage/VerifyPhoneNumb" +
                    "er\r\n        [HttpGet]\r\n        public async Task<IActionResult> VerifyPhoneNumbe" +
                    "r(string phoneNumber)\r\n        {\r\n            var user = await GetCurrentUserAsy" +
                    "nc();\r\n            if (user == null)\r\n            {\r\n                return View" +
                    "(\"Error\");\r\n            }\r\n            var code = await _userManager.GenerateCha" +
                    "ngePhoneNumberTokenAsync(user, phoneNumber);\r\n            // Send an SMS to veri" +
                    "fy the phone number\r\n            return phoneNumber == null ? View(\"Error\") : Vi" +
                    "ew(new VerifyPhoneNumberViewModel { PhoneNumber = phoneNumber });\r\n        }\r\n\r\n" +
                    "        //\r\n        // POST: /Manage/VerifyPhoneNumber\r\n        [HttpPost]\r\n    " +
                    "    [ValidateAntiForgeryToken]\r\n        public async Task<IActionResult> VerifyP" +
                    "honeNumber(VerifyPhoneNumberViewModel model)\r\n        {\r\n            if (!ModelS" +
                    "tate.IsValid)\r\n            {\r\n                return View(model);\r\n            }" +
                    "\r\n            var user = await GetCurrentUserAsync();\r\n            if (user != n" +
                    "ull)\r\n            {\r\n                var result = await _userManager.ChangePhone" +
                    "NumberAsync(user, model.PhoneNumber, model.Code);\r\n                if (result.Su" +
                    "cceeded)\r\n                {\r\n                    await _signInManager.SignInAsyn" +
                    "c(user, isPersistent: false);\r\n                    return RedirectToAction(nameo" +
                    "f(Index), new { Message = ManageMessageId.AddPhoneSuccess });\r\n                }" +
                    "\r\n            }\r\n            // If we got this far, something failed, redisplay " +
                    "the form\r\n            ModelState.AddModelError(string.Empty, \"Failed to verify p" +
                    "hone number\");\r\n            return View(model);\r\n        }\r\n\r\n        //\r\n      " +
                    "  // POST: /Manage/RemovePhoneNumber\r\n        [HttpPost]\r\n        [ValidateAntiF" +
                    "orgeryToken]\r\n        public async Task<IActionResult> RemovePhoneNumber()\r\n    " +
                    "    {\r\n            var user = await GetCurrentUserAsync();\r\n            if (user" +
                    " != null)\r\n            {\r\n                var result = await _userManager.SetPho" +
                    "neNumberAsync(user, null);\r\n                if (result.Succeeded)\r\n             " +
                    "   {\r\n                    await _signInManager.SignInAsync(user, isPersistent: f" +
                    "alse);\r\n                    return RedirectToAction(nameof(Index), new { Message" +
                    " = ManageMessageId.RemovePhoneSuccess });\r\n                }\r\n            }\r\n   " +
                    "         return RedirectToAction(nameof(Index), new { Message = ManageMessageId." +
                    "Error });\r\n        }\r\n\r\n        //\r\n        // GET: /Manage/ChangePassword\r\n    " +
                    "    [HttpGet]\r\n        public IActionResult ChangePassword()\r\n        {\r\n       " +
                    "     return View();\r\n        }\r\n\r\n        //\r\n        // POST: /Manage/ChangePas" +
                    "sword\r\n        [HttpPost]\r\n        [ValidateAntiForgeryToken]\r\n        public as" +
                    "ync Task<IActionResult> ChangePassword(ChangePasswordViewModel model)\r\n        {" +
                    "\r\n            if (!ModelState.IsValid)\r\n            {\r\n                return Vi" +
                    "ew(model);\r\n            }\r\n            var user = await GetCurrentUserAsync();\r\n" +
                    "            if (user != null)\r\n            {\r\n                var result = await" +
                    " _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);\r\n" +
                    "                if (result.Succeeded)\r\n                {\r\n                    aw" +
                    "ait _signInManager.SignInAsync(user, isPersistent: false);\r\n                    " +
                    "_logger.LogInformation(3, \"User changed their password successfully.\");\r\n       " +
                    "             return RedirectToAction(nameof(Index), new { Message = ManageMessag" +
                    "eId.ChangePasswordSuccess });\r\n                }\r\n                AddErrors(resu" +
                    "lt);\r\n                return View(model);\r\n            }\r\n            return Red" +
                    "irectToAction(nameof(Index), new { Message = ManageMessageId.Error });\r\n        " +
                    "}\r\n\r\n        //\r\n        // GET: /Manage/SetPassword\r\n        [HttpGet]\r\n       " +
                    " public IActionResult SetPassword()\r\n        {\r\n            return View();\r\n    " +
                    "    }\r\n\r\n        //\r\n        // POST: /Manage/SetPassword\r\n        [HttpPost]\r\n " +
                    "       [ValidateAntiForgeryToken]\r\n        public async Task<IActionResult> SetP" +
                    "assword(SetPasswordViewModel model)\r\n        {\r\n            if (!ModelState.IsVa" +
                    "lid)\r\n            {\r\n                return View(model);\r\n            }\r\n\r\n     " +
                    "       var user = await GetCurrentUserAsync();\r\n            if (user != null)\r\n " +
                    "           {\r\n                var result = await _userManager.AddPasswordAsync(u" +
                    "ser, model.NewPassword);\r\n                if (result.Succeeded)\r\n               " +
                    " {\r\n                    await _signInManager.SignInAsync(user, isPersistent: fal" +
                    "se);\r\n                    return RedirectToAction(nameof(Index), new { Message =" +
                    " ManageMessageId.SetPasswordSuccess });\r\n                }\r\n                AddE" +
                    "rrors(result);\r\n                return View(model);\r\n            }\r\n            " +
                    "return RedirectToAction(nameof(Index), new { Message = ManageMessageId.Error });" +
                    "\r\n        }\r\n\r\n        //GET: /Manage/ManageLogins\r\n        [HttpGet]\r\n        p" +
                    "ublic async Task<IActionResult> ManageLogins(ManageMessageId? message = null)\r\n " +
                    "       {\r\n            ViewData[\"StatusMessage\"] =\r\n                message == Ma" +
                    "nageMessageId.RemoveLoginSuccess ? \"The external login was removed.\"\r\n          " +
                    "      : message == ManageMessageId.AddLoginSuccess ? \"The external login was add" +
                    "ed.\"\r\n                : message == ManageMessageId.Error ? \"An error has occurre" +
                    "d.\"\r\n                : \"\";\r\n            var user = await GetCurrentUserAsync();\r" +
                    "\n            if (user == null)\r\n            {\r\n                return View(\"Erro" +
                    "r\");\r\n            }\r\n            var userLogins = await _userManager.GetLoginsAs" +
                    "ync(user);\r\n            var schemes = await _signInManager.GetExternalAuthentica" +
                    "tionSchemesAsync();\r\n            var otherLogins = schemes.Where(auth => userLog" +
                    "ins.All(ul => auth.Name != ul.LoginProvider)).ToList(); ViewData[\"ShowRemoveButt" +
                    "on\"] = user.PasswordHash != null || userLogins.Count > 1;\r\n            return Vi" +
                    "ew(new ManageLoginsViewModel\r\n            {\r\n                CurrentLogins = use" +
                    "rLogins,\r\n                OtherLogins = otherLogins\r\n            });\r\n        }\r" +
                    "\n\r\n        //\r\n        // POST: /Manage/LinkLogin\r\n        [HttpPost]\r\n        [" +
                    "ValidateAntiForgeryToken]\r\n        public IActionResult LinkLogin(string provide" +
                    "r)\r\n        {\r\n            // Request a redirect to the external login provider " +
                    "to link a login for the current user\r\n            var redirectUrl = Url.Action(\"" +
                    "LinkLoginCallback\", \"Manage\");\r\n            var properties = _signInManager.Conf" +
                    "igureExternalAuthenticationProperties(provider, redirectUrl, _userManager.GetUse" +
                    "rId(User));\r\n            return Challenge(properties, provider);\r\n        }\r\n\r\n " +
                    "       //\r\n        // GET: /Manage/LinkLoginCallback\r\n        [HttpGet]\r\n       " +
                    " public async Task<ActionResult> LinkLoginCallback()\r\n        {\r\n            var" +
                    " user = await GetCurrentUserAsync();\r\n            if (user == null)\r\n           " +
                    " {\r\n                return View(\"Error\");\r\n            }\r\n            var info =" +
                    " await _signInManager.GetExternalLoginInfoAsync(await _userManager.GetUserIdAsyn" +
                    "c(user));\r\n            if (info == null)\r\n            {\r\n                return " +
                    "RedirectToAction(nameof(ManageLogins), new { Message = ManageMessageId.Error });" +
                    "\r\n            }\r\n            var result = await _userManager.AddLoginAsync(user," +
                    " info);\r\n            var message = result.Succeeded ? ManageMessageId.AddLoginSu" +
                    "ccess : ManageMessageId.Error;\r\n            return RedirectToAction(nameof(Manag" +
                    "eLogins), new { Message = message });\r\n        }\r\n\r\n        #region Helpers\r\n\r\n " +
                    "       private void AddErrors(IdentityResult result)\r\n        {\r\n            for" +
                    "each (var error in result.Errors)\r\n            {\r\n                ModelState.Add" +
                    "ModelError(string.Empty, error.Description);\r\n            }\r\n        }\r\n\r\n      " +
                    "  public enum ManageMessageId\r\n        {\r\n            AddPhoneSuccess,\r\n        " +
                    "    AddLoginSuccess,\r\n            ChangePasswordSuccess,\r\n            SetTwoFact" +
                    "orSuccess,\r\n            SetPasswordSuccess,\r\n            RemoveLoginSuccess,\r\n  " +
                    "          RemovePhoneSuccess,\r\n            Error\r\n        }\r\n\r\n        private T" +
                    "ask<ApplicationUser> GetCurrentUserAsync()\r\n        {\r\n            return _userM" +
                    "anager.GetUserAsync(HttpContext.User);\r\n        }\r\n\r\n        #endregion\r\n    }\r\n" +
                    "}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
