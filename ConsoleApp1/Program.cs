using System;

namespace ConsoleApp1
{
    class Program
    
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            input = Console.ReadLine();
            string[] censoredWords = {"капибарами", "капибарой", "капибарах", "капибарам", "капибара", 
                "капибары", "капибаре", "капибару", "капибар"};
            foreach(string censoredWord in censoredWords)
            {
                int index = input.IndexOf(censoredWord, StringComparison.CurrentCultureIgnoreCase);
                if (index != -1)
                {
                    input = input.Replace(censoredWord, new string('*', censoredWord.Length), 
                        StringComparison.CurrentCultureIgnoreCase);
                } 
            }
            Console.WriteLine(input);

            
        }
    }
}