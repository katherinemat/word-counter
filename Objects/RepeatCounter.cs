using Nancy;
using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _word;
    private string _phrase;
    private string[] _words;

    public RepeatCounter (string word, string phrase)
    {
      _word = word;
      _phrase = phrase;
      _words = _phrase.Split(' ');
    }

    public bool CountRepeats()
    {
      foreach(string one in _words)
      {
        if(one == _word)
        {
          return true;
        }
      }
      return false;
    }
  }
}
