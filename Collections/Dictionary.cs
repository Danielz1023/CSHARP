using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSHARP.Collections
{
    public class Dictionary
    {
        public static Dictionary<string,int> CountWords(string text){
            Dictionary<string,int> frequencies;
            frequencies = new Dictionary<string, int>();

            string[] words = Regex.Split(text,@"\W+");

            foreach(string word in words){
                if(frequencies.ContainsKey(word)){
                    frequencies[word]++;
                }else{
                    frequencies[word] = 1;
                }
            }
            
            return frequencies;
        }
    }
}