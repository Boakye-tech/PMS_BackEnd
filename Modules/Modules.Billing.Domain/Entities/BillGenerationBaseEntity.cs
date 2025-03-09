using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Billing.Domain.Entities
{

    public class BillGenerationBaseEntity
    {
        [Key]
        public int BillId { get; set; }

        [Required]
        [StringLength(4)]
        public string BillingTypeInitial { get; set; }

        [Required]
        public int BatchNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string? BillNumber { get; set; }

        [Required]
        public int PropertyTypeId { get; set; }

        [Required]
        [StringLength(25)]
        public string? PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        public int HouseType { get; set; }

        [Required]
        public int CommunityCode { get; set; }

        public int DebtorType { get; set; }

        public int GroupNumber { get; set; }

        [Required]
        public double RentAmount { get; set; }

        [Required]
        public int AccountCode { get; set; }

        [Required]
        public int ContraAccountCode { get; set; }

        [Required]
        public DateTime BillingDate { get; set; }

        [Required]
        public int BillYear { get; set; }

        [Required]
        [StringLength(150)]
        public string? Narration { get; set; }

        [Required]
        [StringLength(50)]
        public string? CreatedBy { get; set; }


        public BillGenerationBaseEntity()
        {
        }
    }

}

