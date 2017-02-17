using Nancy;
using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _word;
    private string _phrase;

    public RepeatCounter (string word, string phrase)
    {
      _word = word;
      _phrase = phrase;
    }

    public bool CountRepeats()
    {
      if(_word == _phrase)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
