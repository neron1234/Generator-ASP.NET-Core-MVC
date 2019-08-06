﻿using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace Mobioos.Generators.AspNetCore
{
    public partial class ManageAddPhoneNumber : TemplateBase
    {
        public ManageAddPhoneNumber(SmartAppInfo model)
            : base(model)
        {

        }

        public override string OutputPath => "Views\\GeneratorManage\\AddPhoneNumber.cshtml";
    }
}
