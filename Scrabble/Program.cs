using System;

namespace Scrabble.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Scrabble");
      Console.WriteLine("Enter a word to see its score");
      string response = Console.ReadLine();
      Word newWord = new Word(response);
      int result = newWord.Letter(response);
      Console.WriteLine("The word " + response + " has a score of " + result);
      Main();
    }
  }
}
