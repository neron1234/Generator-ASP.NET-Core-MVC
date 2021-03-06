﻿using Mobioos.Generators.AspNetCore.Security.Steps;
using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace Mobioos.Generators.AspNetCore
{
    [WorkFlow(Id = "AspNetCoreSecurityWorkflow", Order = 4)]
    public class SecurityWorkflow : IWorkflow
    {
        public string Id => "AspNetCoreSecurityWorkflow";

        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<SecurityWritingStep>()
                   .Then<WorkFlowEndStepBase>();
        }
    }
}
