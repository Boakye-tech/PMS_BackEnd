﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Management
{
	public class Invoice
	{
        [Key]
        public int InvoiceId { get; set; }

        public string InvoiceNumber { get; set; }

		public DateTime InvoiceDate { get; set; }

        public string PropertyNumber { get; set; }

        public double Acreage { get; set; }

        public string TransactionCode { get; set; }

        public string TransactionNumber { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string CustomerCode { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerEmailAddress { get; set; }

        public string CustomerPhoneNumber { get; set; }

        public double InvoiceAmount { get; set; }

        public int Status { get; set; }

        public string CreatedBy { get; set; }



        public Invoice()
		{
		}
	}



}

