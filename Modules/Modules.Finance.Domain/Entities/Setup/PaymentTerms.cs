// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/PaymentTerms.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 4:24 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class PaymentTerms : AuditableEntity
{
	[Key]
	[Required]
	public int PaymentTermsId { get; private set; }

	[Required]
	public int PaymentTerm { get; private set; }

	public PaymentTerms(int paymentTerm)
	{
		PaymentTerm = paymentTerm;
	}

	public static PaymentTerms Create(int paymentTerm)
	{
		Validate(0, paymentTerm);
		return new PaymentTerms(paymentTerm);
	}

	public void Update(int paymentTermsId, int paymentTerm)
	{
		Validate(paymentTermsId, paymentTerm);
		PaymentTerm = paymentTerm;
	}

	private static void Validate(int paymentTermsId, int paymentTerm)
	{
		if (paymentTermsId < 0)
			throw new ArgumentException("The payment terms id must be greater than zero.");

		if (paymentTerm <= 0)
			throw new ArgumentException("The payment term must be greater than zero.");
	}
}

