using System;

namespace SubString_Sniper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will finds and returns the number of");
            Console.WriteLine("Substrings inside a string.");

            Console.WriteLine("The number of 'abc' matches: {0}", Substring_Sniper("abc", "abcAAFDSAabcabcZADWACabcabcZAWabc", 3));
            Console.ReadLine();
        }

        public static int Substring_Sniper(string substring, string Long_word, int index)
        {
            int count = 0;
            int match = 0;

            if (index < (Long_word.Length - substring.Length) && index > 0)
            {
                for (int i = index; i <= Long_word.Length - substring.Length; i++)
                {
                    for (int j = 0; j < substring.Length; j++)
                    {
                        ///The bottom code will cause the 1st word in substring to match
                        ///the 1st word in Long_word, the 2nd_word in substring to match
                        ///the 2nd word in Long_word to match, the 3rd to match, etc...
                        ///REGARDLESS of where "i" is. This is because if the [i+j].

                        count = (substring[j] == Long_word[i + j]) ? count += 1 : 0;
                        match = (count == substring.Length) ? match += 1 : match;
                    }
                }

                return match;
            }

            else
            {
                return 0;
            }
        }
    } 
}
