// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/ValueObjects/WorkflowState.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 6:43 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Domain.ValueObjects
{
    public sealed record WorkflowState
    {
        public static readonly WorkflowState ApplicationReceived = new("ApplicationReceived");
        public static readonly WorkflowState ProposalGeneration = new("ProposalGeneration");
        public static readonly WorkflowState AwaitingCustomerResponse = new("AwaitingCustomerResponse");
        public static readonly WorkflowState AcceptanceProcessing = new("AcceptanceProcessing");
        public static readonly WorkflowState DocumentGeneration = new("DocumentGeneration");
        public static readonly WorkflowState Completed = new("Completed");

        public string Value { get; }

        private WorkflowState(string value) => Value = value;

        public static WorkflowState FromString(string value)
        {
            return value?.ToLower() switch
            {
                "applicationreceived" => ApplicationReceived,
                "proposalgeneration" => ProposalGeneration,
                "awaitingcustomerresponse" => AwaitingCustomerResponse,
                "acceptanceprocessing" => AcceptanceProcessing,
                "documentgeneration" => DocumentGeneration,
                "completed" => Completed,
                _ => throw new ArgumentException($"Invalid workflow state: {value}")
            };
        }

        public static IEnumerable<WorkflowState> GetAll()
        {
            yield return ApplicationReceived;
            yield return ProposalGeneration;
            yield return AwaitingCustomerResponse;
            yield return AcceptanceProcessing;
            yield return DocumentGeneration;
            yield return Completed;
        }

        public static implicit operator string(WorkflowState state) => state.Value;
        public override string ToString() => Value;
    }
}

