// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.Security.Cryptography;

namespace Modules.Users.Application.Helpers
{
	public class PasswordGenerator
	{
        private static readonly string Uppercase = "ABCDEFGHJKLMNPQRSTUVWXYZ";
        private static readonly string Lowercase = "abcdefghijkmnopqrstuvwxyz";
        private static readonly string Digits = "0123456789";
        private static readonly string SpecialChars = "!@#$%^&*";
        private static readonly string AllChars = Uppercase + Lowercase + Digits + SpecialChars;

        public static string GenerateTemporaryPassword(int length = 12)
        {
            if (length < 4) throw new ArgumentException("Password length must be at least 4.");

            var rng = RandomNumberGenerator.Create();
            var password = new char[length];

            // Ensure at least one character from each category
            password[0] = Uppercase[GetRandomNumber(rng, Uppercase.Length)];
            password[1] = Lowercase[GetRandomNumber(rng, Lowercase.Length)];
            password[2] = Digits[GetRandomNumber(rng, Digits.Length)];
            password[3] = SpecialChars[GetRandomNumber(rng, SpecialChars.Length)];

            // Fill the rest of the password randomly
            for (int i = 4; i < length; i++)
            {
                password[i] = AllChars[GetRandomNumber(rng, AllChars.Length)];
            }

            // Shuffle the password to prevent predictable patterns
            return new string(password.OrderBy(_ => GetRandomNumber(rng, length)).ToArray());
        }

        private static int GetRandomNumber(RandomNumberGenerator rng, int max)
        {
            byte[] buffer = new byte[1];
            rng.GetBytes(buffer);
            return buffer[0] % max;
        }
    }
}

