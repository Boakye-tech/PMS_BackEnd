using System;
using StringRandomizer;
using StringRandomizer.Options;

namespace Modules.Users.Application.Helpers
{
	public static class NumberGenerator
	{
        //public static string OTPGenerator()
        //{
        //    return Generator(6);
        //}

        public static string Generator(int length)
        {
            var randomizer = new Randomizer(length, new DefaultRandomizerOptions(hasNumbers: true, hasLowerAlphabets: false, hasUpperAlphabets: true, hasSpecialChars: false));
            string result = randomizer.Next();
            return result;
        }


    }
}

