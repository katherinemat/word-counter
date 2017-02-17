using Xunit;
using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {
    // [Fact]
    // public void CountRepeats_ReturnInput_Input()
    // {
    //   string userInput = "steak";
    //   RepeatCounter newRepeatCounter = new RepeatCounter(userInput);
    //   string output = newRepeatCounter.CountRepeats();
    //   string expectedOutput = "steak";
    //   Assert.Equal(expectedOutput, output);
    // }
    [Fact]
    public void CountRepeats_CheckTwoEqualWords_True()
    {
      string userInput1 = "tennis";
      string userInput2 = "tennis";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput1, userInput2);
      bool output = newRepeatCounter.CountRepeats();
      bool expectedOutput = true;
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_CheckTwoEqualSentences_True()
    {
      string userInput1 = "I can't!";
      string userInput2 = "I can't!";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput1, userInput2);
      bool output = newRepeatCounter.CountRepeats();
      bool expectedOutput = true;
      Assert.Equal(expectedOutput, output);
    }
  }
}
