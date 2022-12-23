using System.Text.RegularExpressions;

namespace Final_example
{
    public class Algorithms
    {

        public static string RemoveConsonant(string word)
        {
            string result = Regex.Replace(word, @"[^aeiouyAEIOUY]", "");

            return result;
        }

        public static string RemoveVowel(string word)
        {
            string result = Regex.Replace(word, @"[aeiouyAEIOUY]", "");

            return result;
        }
        
        public static string LongestInSentence(string word)
        {
            string[] words = word.Split(new[] { " " }, StringSplitOptions.None);
            string result = string.Empty;
            int len = 0;
            foreach(string s in words)
            {
                if(s.Length > len)
                {
                    result= s;
                    len = s.Length;
                }
            }

            return result;
        }

        public static string ShortestInSentence(string word)
        {
            string[] words = word.Split(new[] { " " }, StringSplitOptions.None);
            string result = string.Empty;
            int len = 0;
            foreach (string s in words)
            {
                if (s.Length > len)
                {
                    result = s;
                    len = s.Length;
                }
            }

            return result;
        }
    }
}
