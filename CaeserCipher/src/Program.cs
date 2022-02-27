using System;

namespace CaeserCipher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the message you want to cipher or decipher:");
            string message = ReadMessageInput();
            Console.WriteLine("Enter the number of shifts for the alphabet:");
            int shift = ReadShiftInput();

            CaeserCipher caeserCipher = new CaeserCipher(message);
            string encryptedMessage = caeserCipher.CipherMessage(caeserCipher.message, shift);
            string decryptedMessage = caeserCipher.CipherMessage(caeserCipher.message, 26 - shift);

            Console.WriteLine("\nThe encrypted message with Caeser Cipher technique: ");
            Console.WriteLine(encryptedMessage);
            Console.WriteLine("The decrypted message with Caeser Cipher technique: ");
            Console.WriteLine(decryptedMessage);
        }

        /// <summary>
        /// Reads and validates the message from user.
        /// </summary>
        /// <returns>The message.</returns>
        private static string ReadMessageInput()
        {
            var message = Console.ReadLine();

            while (string.IsNullOrEmpty(message))
            {
                Console.WriteLine("Please, input a valid message.");
                message = Console.ReadLine();
            }

            return message;
        }

        /// <summary>
        /// Reads and validates the number of shifts from user.
        /// </summary>
        /// <returns>The number of shifts.</returns>
        private static int ReadShiftInput()
        {
            var shiftAsString = Console.ReadLine();

            int shift;
            while(!int.TryParse(shiftAsString, out shift))
            {
                Console.WriteLine("Please, enter a number of shifts.");
                shiftAsString = Console.ReadLine();
            }

            return shift;
        }
    }
}