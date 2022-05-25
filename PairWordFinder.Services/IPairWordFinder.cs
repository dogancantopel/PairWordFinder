using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairWordFinder.Services
{
    public interface IPairWordFinder
    {
        string FindPairWord(List<string> wordList, int length);
    }
}
