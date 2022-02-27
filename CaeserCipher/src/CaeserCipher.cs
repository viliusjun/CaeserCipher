using System;

namespace CaeserCipher
{
    public class CaeserCipher
    {
        public string message { get; set; }

        public CaeserCipher(string message)
        {
            this.message = message;
        }

        public CaeserCipher()
        {
        }

        /// <summary>
        /// Encrypts the message using the Caeser Cipher technique.
        /// </summary>
        /// <param name="message">The message you want to encrypt.</param>
        /// <param name="shift">The number of shifts to the left in the alphabet.</param>
        /// <returns>Returns the encrypted message. Return an empty string if message is null or empty.</returns>
        public string CipherMessage(string message, int shift)
        {
            if (String.IsNullOrEmpty(message))
            {
                return "";
            }
            
            string encrypted = "";
            
            foreach (char letter in message)
            {
                encrypted += CipherLetter(letter, shift);
            }
            
            return encrypted;
        }

        /// <summary>
        /// Using the Caeser Cipher technique returns an encrypted letter based on the number of shifts.
        /// </summary>
        /// <param name="letter">The letter you want to encrypt.</param>
        /// <param name="shift">The number of shifts to the left in the alphabet.</param>
        /// <returns>Returns the encrypted letter. Returns the char passed if it is not a letter.</returns>
        public char CipherLetter(char letter, int shift)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }
            
            char offset = char.IsUpper(letter) ? 'A' : 'a';
            char encryptedLetter = (char)((letter + shift - offset) % 26 + offset);
            
            return encryptedLetter;
        }
    }
}