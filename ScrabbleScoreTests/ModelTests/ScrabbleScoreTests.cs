using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void LetterScoreDictionary_ScoreAndCharacterKeyValuePair_Int()
    {
      int userInput = Word.GetScore('A');
      Assert.AreEqual(1, userInput);
    }

    [TestMethod]
    public void CalculateWordScore_EnterWordAndReturnScore_Int()
    {
      Word newWord = new Word();
      string userWord = "hello";
      int testScore = newWord.ScoreCalculator(userWord);
      Assert.AreEqual(8, testScore);
    }
  }
}