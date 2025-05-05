// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Presentation.Constants
{
    /// <summary>
    /// Customer validation constants
    /// </summary>
    public static class CustomerConstants
    {
        /// <summary>
        /// Error Unauthorized
        /// </summary>
        public const string ErrorUnauthorized = "Unauthorized";

        /// <summary>
        /// Error Expatriate Null or Empty
        /// </summary>
        public const string ErrorExpatriateNull = "Expatriate details cannot be null or empty.";

        /// <summary>
        /// Error Resident Permit Null or Empty
        /// </summary>
        public const string ErrorResidentPermitNull = "Resident permit number cannot be null or empty.";

        /// <summary>
        /// Error Non-Resident Null or Empty
        /// </summary>
        public const string ErrorNonResidentNull = "Non-resident contact person details cannot be null or empty.";

        /// <summary>
        /// Error Contact Person FullName Null or Empty
        /// </summary>
        public const string ErrorContactFullNameNull = "Contact person's fullname cannot be null or empty.";

        /// <summary>
        /// Error Contact Person EmailAddress Null or Empty
        /// </summary>
        public const string ErrorContactEmailNull = "Contact person's email address cannot be null or empty.";

        /// <summary>
        /// Error Contact Person PhoneNumber Null or Empty
        /// </summary>
        public const string ErrorContactPhoneNull = "Contact person's phone number cannot be null or empty.";

        /// <summary>
        /// Error CoLesse Empty or Null
        /// </summary>
        public const string ErrorCoLesseEmpty = "Co-Lesse cannot be empty or null";

        /// <summary>
        /// Error Dependent Empty or Null
        /// </summary>
        public const string ErrorDependentEmpty = "Dependant cannot be empty or null";

        /// <summary>
        /// StatusCode InternalServer Error
        /// </summary>
        public const int StatusCodeInternalServerError = 500;
    }
}

