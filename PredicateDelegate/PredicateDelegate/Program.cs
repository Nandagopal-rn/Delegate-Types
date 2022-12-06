using System;

namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking Vowels using Predicate Delegate");
            
            var CheckVowel = new Predicate<char>(IsVowel);
            DisplayLetter(CheckVowel);
        }

        static void DisplayLetter(Predicate<char> VowelDisplay)
        {
            Console.WriteLine(VowelDisplay.Invoke('a'));
            Console.WriteLine(VowelDisplay.Invoke('A'));
            Console.WriteLine(VowelDisplay.Invoke('E'));
            Console.WriteLine(VowelDisplay.Invoke('s'));
            Console.WriteLine(VowelDisplay.Invoke('X'));
            Console.WriteLine(VowelDisplay.Invoke('i'));
            Console.WriteLine(VowelDisplay.Invoke('k'));
        }

        static bool IsVowel(char letters)
        {
            bool IsVowelLetter = false;
            switch (char.ToLower(letters))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    IsVowelLetter = true;
                    break;
                default:
                    break;
            }
            if (IsVowelLetter)
            {
                return true;
            }
            return false;
        }
    }
}
