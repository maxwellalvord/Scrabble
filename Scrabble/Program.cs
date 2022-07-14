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
      if (response.Length > 20)
      {
        Console.WriteLine("ERROR: Please enter a word shorter than 20 characters!");
        Main();
      }
      Word newWord = new Word(response);
      int result = newWord.Letter(response);
      Console.WriteLine("The word " + response + " has a score of " + result);
      Main();
    }
  }
}
