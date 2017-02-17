using Nancy;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        string userWord = Request.Form["word"];
        string userPhrase = Request.Form["phrase"];
        RepeatCounter newRepeatCounter = new RepeatCounter(userWord, userPhrase);
        int userOutput = newRepeatCounter.CountRepeats();
        return View["results.cshtml", userOutput];
      };
    }
  }
}
