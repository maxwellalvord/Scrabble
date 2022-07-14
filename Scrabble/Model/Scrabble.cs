
using System.Collections.Generic;



namespace Scrabble.Models
{
  public class Word
  {
    public string Content { get; set;}
    

    public int Letter (string word)
    {
      int Score = 0;
      for ( int i = 0; i <= word.Length -1 ; i++)
      {
        
        if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'l' || word[i] == 'n' || word[i] == 'r' || word[i] == 's' || word[i] == 't')
        {
          Score += 1;
        }
        else if (word[i] == 'd' || word[i] ==  'g')
        {
          Score += 2;
        }
        else if (word[i] == 'b' || word[i] ==  'c' || word[i] ==  'm' || word[i] ==  'p')
        {
          Score += 3;
        }
        else if (word[i] == 'f' || word[i] ==  'h' || word[i] ==  'v' || word[i] ==  'w' || word[i] == 'y')
        {
          Score += 4;
        }
        else if (word[i] == 'k' )
        {
          Score += 5;
        }
        else if (word[i] == 'j' || word[i] == 'x')
        {
          Score += 8;
        }
        else 
        {
          Score += 10;
        }
      }
      return Score;
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
