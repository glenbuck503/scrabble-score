using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Word
  {

    // Backend Dictionary //
    private static Dictionary<char, int> letterScore = new Dictionary<char, int> ()
    {
      {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1},
      {'D', 2}, {'G', 2},
      {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3},
      {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
      {'K', 5},
      {'J', 8}, {'X', 8},
      {'Q', 10}, {'Z', 10}
    };  

    // Getter Method //
    public static int GetScore(char letter)
    {
      int result;
      if (letterScore.TryGetValue(letter, out result))
      {
        return result;
      }
      else
      {
        return 0;
      }
    } 

    // Calc Score Method //
    public int ScoreCalculator(string word)
    {
      int score = 0;
      foreach (char letter in word)
      {
        score += GetScore(Char.ToUpper(letter));
      }
      return score;
    } 

  }
}