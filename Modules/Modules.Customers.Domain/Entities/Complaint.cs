using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class Complaint
	{
		[Key]
		public int ComplaintId { get; set; }

		public string CustomerCode { get; set; }
		public string ClientName { get; set; }
		public string ContactInformation { get; set; }
		public string PropertyNumber { get; set; }
		public string Locality { get; set; }
		public string DetailsOfComplaint { get; set; }
		public bool IsTheMatterInCourt { get; set; }
		public DateTime ComplaintDate { get; set; }
		public string SubmittedBy { get; set; }

        public string DocumentOne { get; set; }
        public string DocumentTwo { get; set; }
        public string DocumentThree { get; set; }

		public string CreatedBy { get; set; }

	}
}

