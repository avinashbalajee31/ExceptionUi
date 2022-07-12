using System;

namespace VowelException
{
    class StringChecker
    {
        public void StartsWithVowel(String input)
        {
            input = input.ToLower();
            char letter = input[0];
            //Console.WriteLine(letter);
            if (letter == 'a' || letter == 'e' || letter == 'u' || letter == 'o' || letter == 'i')
            {
                Console.WriteLine("input starts with vowel :" + letter);
            }
            else
            {
                throw new ArgumentException("not a vowel");
            }
           
        }
    }
    public class main
    {

        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            StringChecker checker=new StringChecker();
            try
            {
                checker.StartsWithVowel(input);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
           
        }
    }
    
}