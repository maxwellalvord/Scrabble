
using System.Collections.Generic;


namespace Scrabble.Models
{
  public class Word
  {
    public string Content { get; set;}

    public string Letter (string word)//c // length = 1
    {
      // string l = word;
      // int Score = 0;
      // for ( int i = 0; i <= l.Length -1 ; i++)
      // {
       
      // }
      return word;
    }
    // private static List<Word> _instances = new List<Word> {};

    // public static List<Word> GetAll()
    // {
    //   return _instances;
    // }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
    public Word(string content)
    { 
      Content = content;
      // _instances.Add(this);
    }
  }
}
