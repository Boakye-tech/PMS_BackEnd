// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/ValueObjects/ApplicationStatus.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 6:42 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Domain.ValueObjects
{
    public sealed record ApplicationStatus
    {
        public static readonly ApplicationStatus Draft = new("Draft");
        public static readonly ApplicationStatus Submitted = new("Submitted");
        public static readonly ApplicationStatus UnderReview = new("UnderReview");
        public static readonly ApplicationStatus ProposalSent = new("ProposalSent");
        public static readonly ApplicationStatus ProposalAccepted = new("ProposalAccepted");
        public static readonly ApplicationStatus ProposalRejected = new("ProposalRejected");
        public static readonly ApplicationStatus OfferGenerated = new("OfferGenerated");
        public static readonly ApplicationStatus Completed = new("Completed");
        public static readonly ApplicationStatus Cancelled = new("Cancelled");

        public string Value { get; }

        private ApplicationStatus(string value) => Value = value;

        public static ApplicationStatus FromString(string value)
        {
            return value?.ToLower() switch
            {
                "draft" => Draft,
                "submitted" => Submitted,
                "underreview" => UnderReview,
                "proposalsent" => ProposalSent,
                "proposalaccepted" => ProposalAccepted,
                "proposalrejected" => ProposalRejected,
                "offergenerated" => OfferGenerated,
                "completed" => Completed,
                "cancelled" => Cancelled,
                _ => throw new ArgumentException($"Invalid application status: {value}")
            };
        }

        public static IEnumerable<ApplicationStatus> GetAll()
        {
            yield return Draft;
            yield return Submitted;
            yield return UnderReview;
            yield return ProposalSent;
            yield return ProposalAccepted;
            yield return ProposalRejected;
            yield return OfferGenerated;
            yield return Completed;
            yield return Cancelled;
        }

        public static implicit operator string(ApplicationStatus status) => status.Value;
        public override string ToString() => Value;
    }
}

