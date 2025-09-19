// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Domain.Entities.Setup
{
    public class Services : AuditableEntity
    {
        [Key]
        [Required]
        public int ServicesId { get; private set; }

        [Required]
        public int DepartmentId { get; private set; }


        [Required]
        public int RoomNumber { get; private set; }

        [Required]
        [StringLength(50)]
        public string ServiceName { get; private set; }

        [StringLength(100)]
        public string? Descrption { get; private set; }

        public bool HasFee { get; private set; }

        [Required]
        public double Amount { get; private set; }

        [Required]
        public int AccountCode { get; private set; }

        private Services()
        {
            ServiceName = string.Empty;
        }

        public Services(int departmentId, int roomNumber, string serviceName, string? description, bool hasFee, double amount, int accountCode)
        {
            Validate(departmentId, roomNumber, serviceName, amount, accountCode);

            DepartmentId = departmentId;
            RoomNumber = roomNumber;
            ServiceName = serviceName;
            Descrption = description;
            HasFee = hasFee;
            Amount = amount;
            AccountCode = accountCode;
        }

        public static Services Create(int departmentId, int roomNumber, string serviceName, string? description, bool hasFee, double amount, int accountCode)
        {
            Validate(departmentId, roomNumber, serviceName, amount, accountCode);
            return new Services(departmentId, roomNumber, serviceName, description, hasFee, amount, accountCode);
        }

        public void Update(int departmentId, int roomNumber, string serviceName, string? description, bool hasFee, double amount, int accountCode)
        {
            Validate(departmentId, roomNumber, serviceName, amount, accountCode);

            DepartmentId = departmentId;
            RoomNumber = roomNumber;
            ServiceName = serviceName;
            Descrption = description;
            HasFee = hasFee;
            Amount = amount;
            AccountCode = accountCode;
        }

        private static void Validate(int departmentId, int roomNumber, string serviceName, double amount, int accountCode)
        {


            if (departmentId <= 0)
                throw new ArgumentException("Department Id must be greater than zero.");

            if (roomNumber <= 0)
                throw new ArgumentException("Room Number must be greater than zero.");

            if (string.IsNullOrWhiteSpace(serviceName) || serviceName.Length > 50)
                throw new ArgumentException("Service Name must not be empty or exceed 50 characters.");

            if (amount < 0)
                throw new ArgumentException("Amount must be greater than or equal to zero.");

            if (accountCode <= 0)
                throw new ArgumentException("Account Code must be greater than zero.");
        }
    }
}

