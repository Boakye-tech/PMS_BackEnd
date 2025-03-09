using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record JointOwnershipCustomerDto : IndividualCustomerDto
    {
        public IndividualNonResidentCustomerDto? NonResident { get; set; }
        public IndividualExpatriateCustomerDto? Expatriate { get; set; }

        public IEnumerable<CoLesseCustomerDto>? CoLesse { get; set; }

    }

    public record CoLesseCustomerDto : IndividualCustomerDto
    {
        public IndividualNonResidentCustomerDto? NonResident { get; set; }
        public IndividualExpatriateCustomerDto? Expatriate { get; set; }
    }


}

