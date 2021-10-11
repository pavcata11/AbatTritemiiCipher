using System;

namespace AbatTritemiiCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Input Text:");
            var text = Console.ReadLine().ToUpper().ToCharArray();
            string crypttetxt = null;
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (j > 26)
                {
                    j = 0;
                }
                char nextLeter = (char)((int)text[i]+j);
                crypttetxt += nextLeter;
                j++;
            }
            Console.WriteLine(crypttetxt);
            Console.WriteLine("Input Decrypt to Encrypt Text");
            text = Console.ReadLine().ToUpper().ToCharArray();
            string encryptText = null;
            j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (j > 26)
                {
                    j = 0;
                }
                char nextLeter = (char)((int)text[i] - j);
                encryptText += nextLeter;
                j++;
            }
            Console.WriteLine(encryptText);
        }
    }
}
