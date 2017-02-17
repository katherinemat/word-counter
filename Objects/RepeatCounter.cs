using Nancy;
using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _input;

    public RepeatCounter (string input)
    {
      _input = input;
    }

    public string CountRepeats()
    {
      return _input;
    }
  }
}
