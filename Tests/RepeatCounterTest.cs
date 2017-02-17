using Xunit;
using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_ReturnInput_Input()
    {
      string userInput = "steak";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput);
      string output = newRepeatCounter.CountRepeats();
      string expectedOutput = "steak";
      Assert.Equal(expectedOutput, output);
    }
  }
}
