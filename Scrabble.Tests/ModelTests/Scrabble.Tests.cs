using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests 
  { 
    // public void Dispose()
    // {
    //   Word.ClearAll();
    // }
   
   [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_true()
    {
      string wordInput = "car";
      Word newWord = new Word(wordInput);
      Assert.AreEqual(wordInput, newWord.Content);
    }

    [TestMethod]
    public void WordToLetter_ScoreLetters_true()
    {
      string wordInput = "car";
      int wordScore = 5; 
      Word newWord = new Word(wordInput);

      Assert.AreEqual(wordScore, newWord.Letter("car"));
    }
  }
}