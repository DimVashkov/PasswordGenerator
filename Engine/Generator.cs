using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Engine
{
    public class Generator
    {
        private int length;
        private bool symbols;
        private bool numbers;
        private bool lowerCase;
        private bool upperCase;
        private bool excludeSimilar;
        private bool excludeAmbiguous;
        
        private Random random = new Random();

        public Generator(int length, bool symbols, bool numbers, bool lowerCase, bool upperCase, bool excludeSimilar, bool excludeAmbiguous)
        {
            this.length = length;
            this.symbols = symbols;
            this.numbers = numbers;
            this.lowerCase = lowerCase;
            this.upperCase = upperCase;
            this.excludeSimilar = excludeSimilar;
            this.excludeAmbiguous = excludeAmbiguous;
        }

        public String GeneratePassword()
        {   String allValidCharacters = "";
            if (this.symbols){
                allValidCharacters += CreateSymbols();
            }
            if (this.numbers)
            {
                allValidCharacters += CreateNumbers();
            }
            if (this.lowerCase)
            {
                allValidCharacters += CreateLowerCaseLetters();
            }
            if (this.upperCase)
            {
                allValidCharacters += CreateUpperCaseLetters();
            }
            if (this.excludeSimilar)
            {
                allValidCharacters = RemoveSimilarCharacters(allValidCharacters);
            }
            if (this.excludeAmbiguous)
            {
                allValidCharacters = RemoveAmbiguousCharacters(allValidCharacters);
            }

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = allValidCharacters[random.Next(0, allValidCharacters.Length)];
            }

            return new String(chars);
        }

        private String CreateNumbers()
        {
            String validNumbers="";
            for(int i = 0; i < 10; i++)
            {
                validNumbers += i.ToString();
            }
            return validNumbers;
        }

        private String CreateSymbols()
        {
            String validSymbols = "";
            for(char i = '!'; i <= '/'; i++)
            {
                validSymbols += i.ToString();
            }
            for (char i = ':'; i <= '@'; i++)
            {
                validSymbols += i.ToString();
            }
            for (char i = '['; i <= '`'; i++)
            {
                validSymbols += i.ToString();
            }
            for (char i = '{'; i <= '~'; i++)
            {
                validSymbols += i.ToString();
            }

            return validSymbols;
        }
        private String CreateLowerCaseLetters()
        {
            String validCharacters = "";
            for(char i = 'a'; i <= 'z'; i++)
            {
                validCharacters += i.ToString();
            }
            return validCharacters;
        }
        private String CreateUpperCaseLetters()
        {
            String validCharacters = "";
            for (char i = 'A'; i <= 'Z'; i++)
            {
                validCharacters += i.ToString();
            }
            return validCharacters;
        }
        private String RemoveSimilarCharacters(String validCharacters)
        {
            //Done using Replace -> Fine if done for 1-2-3 chars, awful otherwise
            String output = validCharacters.Replace("i", "").Replace("l", "").Replace("1", "").Replace("L", "").Replace("o", "").Replace("0", "").Replace("O", "");
            return output;
        }
        private String RemoveAmbiguousCharacters(String validCharacters)
        {
            String output = Regex.Replace(validCharacters, "[{}/\\*`~,.;:<>]", "");
            return output;
        }
    }
}
