// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using StringRandomizer;
using StringRandomizer.Options;

namespace Modules.Users.Application.Helpers
{
	public static class NumberGenerator
	{
        public static string Generator(int length)
        {
            var randomizer = new Randomizer(length, new DefaultRandomizerOptions(hasNumbers: true, hasLowerAlphabets: false, hasUpperAlphabets: false, hasSpecialChars: false));
            string result = randomizer.Next();
            return result;
        }


    }
}

