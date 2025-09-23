// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/PenaltyTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 2:18 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Domain.Entities.Setup
{
    public class PenaltyType : AuditableEntity
    {
        public int PenaltyTypeId { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Code { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public bool IsActive { get; private set; } = true;

        // Navigation properties
        public virtual ICollection<PenaltyRule> PenaltyRules { get; private set; } = new List<PenaltyRule>();

        // Private constructor for EF Core
        private PenaltyType() { }

        public PenaltyType(string name, string code, string description, bool isActive)
        {
            Validate(name, code, description);
            Name = name;
            Code = code;
            Description = description;
            IsActive = isActive;
            PenaltyRules = new List<PenaltyRule>();
        }

        public static PenaltyType Create(string name, string code, string description, bool isActive = true)
        {
            Validate(name, code, description);
            return new PenaltyType(name, code, description, isActive);
        }

        public void Update(string name, string code, string description, bool isActive)
        {
            Validate(name, code, description);
            Name = name;
            Code = code;
            Description = description;
            IsActive = isActive;
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }

        private static void Validate(string name, string code, string description)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > 100)
                throw new ArgumentException("Name must not be null or exceed 100 characters.");

            if (string.IsNullOrWhiteSpace(code) || code.Length > 20)
                throw new ArgumentException("Code must not be null or exceed 20 characters.");

            if (!string.IsNullOrWhiteSpace(description) && description.Length > 500)
                throw new ArgumentException("Description must not exceed 500 characters.");
        }
    }

}