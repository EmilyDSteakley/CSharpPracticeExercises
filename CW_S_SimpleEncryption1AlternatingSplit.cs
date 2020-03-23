using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_S_SimpleEncryption1AlternatingSplit
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Simple Encryption #1 - Alternating Split

        // For building the encrypted string:
        // Take every 2nd char from the string, then the other chars, that are not every 2nd char, and concat them as new String.
        // Do this n times!

        // Examples:
        // "This is a test!", 1 -> "hsi  etTi sats!"
        // "This is a test!", 2 -> "hsi  etTi sats!" -> "s eT ashi tist!"

        // Write two methods:
        // string Encrypt(string text, int n)
        // string Decrypt(string encryptedText, int n)

        // For both methods:
        // If the input-string is null or empty return exactly this value!
        // If n is <= 0 then return the input text.



        // ---------------------------------------- My Solution ----------------------------------------
        public string Encrypt(string text, int n)
        {
            if (string.IsNullOrEmpty(text) || n <= 0)
                return text;

            while (n > 0)
            {
                var encrypted = new StringBuilder();
                for (int i = 1; i < text.Length; i += 2)
                {
                    encrypted.Append(text[i]);
                }
                for (int j = 0; j < text.Length; j += 2)
                {
                    encrypted.Append(text[j]);
                }
                text = encrypted.ToString();
                n--;
            }

            return text;
        }

        public string Decrypt(string encryptedText, int n)
        {
            if (string.IsNullOrEmpty(encryptedText) || n <= 0)
                return encryptedText;

            while (n > 0)
            {
                var decrypted = new char[encryptedText.Length];
                for (int i = 1, j = 0; i < encryptedText.Length; i += 2, j++)
                {
                    decrypted[i] = encryptedText[j];
                }
                for (int k = 0, l = encryptedText.Length / 2; k < encryptedText.Length; k += 2, l++)
                {
                    decrypted[k] = encryptedText[l];
                }
                encryptedText = string.Join("", decrypted);
                n--;
            }

            return encryptedText;
        }
        // Solved March 23, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public string EncryptBest(string text, int n)
        {
            if (string.IsNullOrWhiteSpace(text) || n <= 0)
            {
                return text;
            }

            while (n != 0)
            {
                text = string.Concat(text.Where((c, i) => i % 2 == 1).Concat(text.Where((c, i) => i % 2 == 0)));

                n--;
            }

            return text;
        }

        public string DecryptBest(string text, int n)
        {
            if (string.IsNullOrWhiteSpace(text) || n <= 0)
            {
                return text;
            }

            while (n != 0)
            {
                string leftPart = string.Concat(text.Take(text.Length / 2));
                string rightPart = string.Concat(text.Skip(text.Length / 2));

                text = string.Concat(Enumerable.Range(0, text.Length).Select(i => i % 2 == 0 ? rightPart[i / 2] : leftPart[i / 2]));

                n--;
            }

            return text;
        }

    } // CW_S_SimpleEncryption1AlternatingSplit class

} // CSharpPracticeExercises namespace
