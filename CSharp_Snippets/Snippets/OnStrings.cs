using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    static class OnStrings
    {

        /// string palindrome
        public static void StringPalindrome()
        {
            string s = Console.ReadLine();
            bool flag = false;
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    flag = false;
                }
                else
                    flag = true;
            }
            if (flag)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

        }


        ///reverse a string
        public static void StringReverse()
        {
            string str = "uday";
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }


        ///reversing the entire string of words
        public static void StringReverseWholeSentence()
        {
            string s = "hello uday kumar";
            string[] words = s.Split(' ');
            string[] output = new string[words.Length];
            int t = 0;
            foreach (var item in words)
            {
                char[] temp = item.ToCharArray();
                for (int i = 0, j = item.Length - 1; i < j; i++, j--)
                {
                    temp[i] = item[j];
                    temp[j] = item[i];
                }
                output[t] = new string(temp);
                t++;
            }
            Console.WriteLine(string.Join(" ", output));
        }


        ///reverse words order in a string
        public static void ReverseWords()
        {
            string s = "uday kumar kuruva";
            Console.WriteLine(string.Join(" ", s.Split(' ').Reverse()));

            string[] words = s.Split(' ');
            string output = string.Empty;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                output += words[i] + " ";
            }
            Console.WriteLine(output);
        }


        ///find the number of chars in a string

        public static void NumberOfCharsInaString()
        {
            string s = "uday kumar";
            Dictionary<char, int> output = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (item != ' ')
                {
                    if (!output.ContainsKey(item))
                    {
                        output.Add(item, 1);
                    }
                    else
                    {
                        output[item]++;
                    }
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }



        /// removing duplicates in a string
        public static void RemoveDuplicates()
        {
            string s = "uday kumar kuruva";
            string output = string.Empty;
            foreach (var item in s)
            {
                if (!output.Contains(item))
                    output += item;
            }
            Console.WriteLine(output);
        }


        ///possible substrings of a given string
        public static void PossibleSubStrings()
        {
            string s = "abcd";
            for (int i = 0; i < s.Length; i++)
            {
                StringBuilder stringBuilder = new StringBuilder(s.Length - 1);
                for (int j = i; j < s.Length; ++j)
                {
                    stringBuilder.Append(s[j]);
                    Console.WriteLine(stringBuilder);
                }

            }
        }


        /// paranthesis check in a given string
        /// 
        public static void ParanthesisCheckOnString()
        {
            string s = "(a+((b-c))";
            int count = 45;
            foreach (var item in s)
            {
                if (item == '(')
                    count++;
                else if (item == ')')
                    count--;
            }
            if(count == 45)
                Console.WriteLine("balanced");
            else
                Console.WriteLine("not balanced");
        }

    }
}
