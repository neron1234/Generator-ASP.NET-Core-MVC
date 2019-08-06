﻿using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace Mobioos.Generators.AspNetCore
{
    public partial class Lockout : TemplateBase
    {
        public Lockout(SmartAppInfo model)
            : base(model)
        {
        }

        public override string OutputPath => "Views\\GeneratorAccount\\Lockout.cshtml";
    }
}
