using NUnit.Framework;
using PairWordFinder.Services;
using System.Collections.Generic;

namespace PairWordFinder.Tests
{
    public class Tests
    {
        IPairWordFinder _pairWordFinder;
        private  List<string> _wordList;
        [SetUp]
        public void Setup()
        {
            _pairWordFinder = new PairWordFinder.Services.PairWordFinder();
            _wordList = new List<string> { "ab", "cd", "ccd", "cd", "dk", "dd", "k", "ddk" };
        }
        [Test]
        public void WhenListNull()
        {
            var result = _pairWordFinder.FindPairWord(null, 0);
            Assert.AreEqual(result, "List not Contains any word");
        }
        [Test]
        public void WhenListEmpty()
        {
            var result = _pairWordFinder.FindPairWord(new List<string>(), 0);
            Assert.AreEqual(result, "List not Contains any word");
        }

        [Test]
        public void WhenLengthIsFive()
        {
            var result = _pairWordFinder.FindPairWord(_wordList, 5);
            Assert.AreEqual(result, "ab ccd");
        }

        [Test]
        public void WhenLengthIsSix()
        {
            var result = _pairWordFinder.FindPairWord(_wordList, 6);
            Assert.AreEqual(result, "ccd ddk");
        }
        [Test]
        public void WhenLengthIsThree()
        {
            var result = _pairWordFinder.FindPairWord(_wordList, 3);
            Assert.AreEqual(result, "ab k");
        }
        [Test]
        public void WhenLengthIsFour()
        {
            var result = _pairWordFinder.FindPairWord(_wordList, 4);
            Assert.AreEqual(result, "ab cd");
        }
    }
}