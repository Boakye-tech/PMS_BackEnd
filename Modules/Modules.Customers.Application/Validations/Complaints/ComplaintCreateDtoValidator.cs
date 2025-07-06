// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Validations/Complaints/ComplaintCreateDtoValidator.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 06/07/2025 6:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using FluentValidation;


namespace Modules.Customers.Application.Validations.Complaints;

public class ComplaintCreateDtoValidator : AbstractValidator<ComplaintCreateDto>
{
    public ComplaintCreateDtoValidator()
    {
        RuleFor(x => x.ComplaintId)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Complaint ID must be greater than or equal to 0.");

        RuleFor(x => x.ComplaintTypeId)
            .GreaterThan(0)
            .WithMessage("Complaint Type ID must be greater than 0.");

        RuleFor(x => x.NatureOfComplaintId)
            .NotNull()
            .NotEmpty()
            .WithMessage("Nature of complaint IDs cannot be null or empty.");

        RuleFor(x => x.NatureOfComplaintId)
            .Must(natureIds => natureIds != null && natureIds.All(id => id > 0))
            .WithMessage("All nature of complaint IDs must be greater than 0.");

        RuleFor(x => x.ComplaintNumber)
            .MaximumLength(10)
            .WithMessage("Complaint number cannot be more than 10 characters.");

        RuleFor(x => x.PropertyNumber)
            .NotEmpty()
            .MaximumLength(50)
            .WithMessage("Property number is required and cannot be more than 50 characters.");

        RuleFor(x => x.PropertyLocation)
            .NotEmpty()
            .MaximumLength(75)
            .WithMessage("Property location is required and cannot be more than 75 characters.");

        RuleFor(x => x.CustomerCode)
            .MaximumLength(10)
            .WithMessage("Customer code cannot be more than 10 characters.");

        RuleFor(x => x.CustomerName)
            .NotEmpty()
            .MaximumLength(200)
            .WithMessage("Customer name is required and cannot be more than 200 characters.");

        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .MaximumLength(15)
            .WithMessage("Phone number is required and cannot be more than 15 characters.");

        RuleFor(x => x.EmailAddress)
            .MaximumLength(75)
            .EmailAddress()
            .When(x => !string.IsNullOrEmpty(x.EmailAddress))
            .WithMessage("Email address must be a valid email format and cannot be more than 75 characters.");

        RuleFor(x => x.IsTheMatterInCourt)
            .MaximumLength(3)
            .WithMessage("Is the matter in court field cannot be more than 3 characters.");

        RuleFor(x => x.DetailsOfComplaint)
            .NotEmpty()
            .WithMessage("Details of complaint is required.");

        RuleFor(x => x.AvailabilityDate)
            .GreaterThan(DateTime.MinValue)
            .WithMessage("Availability date must be a valid date.");

        RuleFor(x => x.ComplaintDate)
            .GreaterThan(DateTime.MinValue)
            .WithMessage("Complaint date must be a valid date.");

        RuleFor(x => x.SubmittedBy)
            .MaximumLength(300)
            .WithMessage("Submitted by field cannot be more than 300 characters.");

        RuleFor(x => x.SubmittedBy_PhoneNumber)
            .MaximumLength(15)
            .WithMessage("Submitted by phone number cannot be more than 15 characters.");

        RuleFor(x => x.DocumentImages)
            .Must(docs => docs == null || docs.All(doc => !string.IsNullOrEmpty(doc)))
            .WithMessage("Document images cannot contain null or empty values.");

        RuleFor(x => x.ComplaintStatus)
            .IsInEnum()
            .WithMessage("Complaint status must be a valid enum value.");

        RuleFor(x => x.Source)
            .IsInEnum()
            .WithMessage("Source must be a valid enum value.");
    }
}