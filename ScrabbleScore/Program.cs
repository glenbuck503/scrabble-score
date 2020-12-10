using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      Word newWord = new Word();
      Console.WriteLine("Enter a word and we'll tell you its score value in Scrabble!: ");
      string userWord = Console.ReadLine();

      int userScore = newWord.ScoreCalculator(userWord);
      Console.WriteLine($"This words Scrabble score is: " + userScore);
    }
  }
}