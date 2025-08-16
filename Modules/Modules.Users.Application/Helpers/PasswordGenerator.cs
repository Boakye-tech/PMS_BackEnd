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
    //public class PasswordGenerator
    //{
    //       private static readonly string Uppercase = "ABCDEFGHJKLMNPQRSTUVWXYZ";
    //       private static readonly string Lowercase = "abcdefghijkmnopqrstuvwxyz";
    //       private static readonly string Digits = "0123456789";
    //       private static readonly string SpecialChars = "!@#$%^&*";
    //       private static readonly string AllChars = Uppercase + Lowercase + Digits + SpecialChars;

    //       public static string GenerateTemporaryPassword(int length = 12)
    //       {
    //           if (length < 4) throw new ArgumentException("Password length must be at least 4.");

    //           var rng = RandomNumberGenerator.Create();
    //           var password = new char[length];

    //           // Ensure at least one character from each category
    //           password[0] = Uppercase[GetRandomNumber(rng, Uppercase.Length)];
    //           password[1] = Lowercase[GetRandomNumber(rng, Lowercase.Length)];
    //           password[2] = Digits[GetRandomNumber(rng, Digits.Length)];
    //           password[3] = SpecialChars[GetRandomNumber(rng, SpecialChars.Length)];

    //           // Fill the rest of the password randomly
    //           for (int i = 4; i < length; i++)
    //           {
    //               password[i] = AllChars[GetRandomNumber(rng, AllChars.Length)];
    //           }

    //           // Shuffle the password to prevent predictable patterns
    //           return new string(password.OrderBy(_ => GetRandomNumber(rng, length)).ToArray());
    //       }

    //       private static int GetRandomNumber(RandomNumberGenerator rng, int max)
    //       {
    //           byte[] buffer = new byte[1];
    //           rng.GetBytes(buffer);
    //           return buffer[0] % max;
    //       }
    //   }



    public class PasswordGenerator
    {
        private static readonly string Uppercase = "ABCDEFGHJKLMNPQRSTUVWXYZ";
        private static readonly string Lowercase = "abcdefghijkmnopqrstuvwxyz";
        private static readonly string Digits = "0123456789";
        private static readonly string SpecialChars = "!@#$%^&*";
        private static readonly string AllChars = Uppercase + Lowercase + Digits + SpecialChars;

        // Matches Identity password requirements
        private const int RequiredLength = 8;
        private const bool RequireUppercase = true;
        private const bool RequireLowercase = true;
        private const bool RequireDigit = true;
        private const bool RequireNonAlphanumeric = true;
        private const int RequiredUniqueChars = 1;

        public static string GenerateTemporaryPassword()
        {
            if (RequiredLength < 8)
                throw new ArgumentException("Password length must be at least 8.");

            var passwordChars = new char[RequiredLength];
            int pos = 0;

            // Add required character types
            if (RequireUppercase) passwordChars[pos++] = GetRandomChar(Uppercase);
            if (RequireLowercase) passwordChars[pos++] = GetRandomChar(Lowercase);
            if (RequireDigit) passwordChars[pos++] = GetRandomChar(Digits);
            if (RequireNonAlphanumeric) passwordChars[pos++] = GetRandomChar(SpecialChars);

            // Fill remaining with random chars
            while (pos < RequiredLength)
            {
                passwordChars[pos++] = GetRandomChar(AllChars);
            }

            // Secure shuffle
            Shuffle(passwordChars);

            // Ensure unique char requirement
            if (passwordChars.Distinct().Count() < RequiredUniqueChars)
            {
                var uniqueChars = passwordChars.Distinct().ToList();
                while (uniqueChars.Count < RequiredUniqueChars)
                {
                    var newChar = GetRandomChar(AllChars.Except(uniqueChars).ToArray());
                    int replaceIndex = GetRandomInt(0, passwordChars.Length);
                    passwordChars[replaceIndex] = newChar;
                    uniqueChars = passwordChars.Distinct().ToList();
                }
            }

            return new string(passwordChars);
        }

        private static char GetRandomChar(string chars) =>
            chars[GetRandomInt(0, chars.Length)];

        private static char GetRandomChar(char[] chars) =>
            chars[GetRandomInt(0, chars.Length)];

        private static int GetRandomInt(int minValue, int maxValue) =>
            RandomNumberGenerator.GetInt32(minValue, maxValue);

        private static void Shuffle(char[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = GetRandomInt(0, i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
    }

}

