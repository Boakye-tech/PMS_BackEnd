// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 4:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
    public class PaymentTermsRepository : Repository<PaymentTerms>, IPaymentTermsRepository
    {
        public PaymentTermsRepository(FinanceDbContext dbContext) : base(dbContext)
        {
        }
    }
}
