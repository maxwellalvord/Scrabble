
using System.Collections.Generic;


namespace Scrabble.Models
{
  public class Word
  {
    public string Content { get; set;}
    private static List<Word> _instances = new List<Word> {};

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
      _instances.Add(this);
    }
  }
}
