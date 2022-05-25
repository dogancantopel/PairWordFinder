using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PairWordFinder.Services
{
    public class PairWordFinder : IPairWordFinder
    {
        public string FindPairWord(List<string> wordList, int length)
        {

            var resultMessage = new StringBuilder();
            if (wordList == null || !wordList.Any())
                return resultMessage.Append("List not Contains any word").ToString();

            var checkList = new HashSet<string>();

            for (int i = 0; i < wordList.Count; i++)
            {
                int j = length - wordList[i].Length;//Getting Remaing Length

                var otherWord = checkList.FirstOrDefault(m => m.Length == j);//if checkList contain remaining length word then get it
                
                //Best case 2 iteration
                //worst Case wordList Count iteration
                
                if (otherWord != null)
                { 
                    resultMessage.Append(otherWord);
                    resultMessage.Append(" ");
                    resultMessage.Append(wordList[i]);
                    return resultMessage.ToString();
                }
                checkList.Add(wordList[i]);
            }
            return resultMessage.ToString();

        }
    }
}
