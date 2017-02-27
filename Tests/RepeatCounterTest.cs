using Xunit;
using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_FindOneLetter_1()
    {
      string userInput1 = "e";
      string userInput2 = "e";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput1, userInput2);
      int output = newRepeatCounter.CountRepeats();
      int expectedOutput = 1;
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_FindsEqualWords_1()
    {
      string userInput1 = "tennis";
      string userInput2 = "tennis";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput1, userInput2);
      int output = newRepeatCounter.CountRepeats();
      int expectedOutput = 1;
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_CantMatchWithSentenceAsWord_0()
    {
      string userInput1 = "I can't!";
      string userInput2 = "I can't!";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput1, userInput2);
      int output = newRepeatCounter.CountRepeats();
      int expectedOutput = 0;
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_CheckForWordInSentence_1()
    {
      string userInput1 = "dog";
      string userInput2 = "That dog is happy.";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput1, userInput2);
      int output = newRepeatCounter.CountRepeats();
      int expectedOutput = 1;
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_CheckForWordCapitalizedInSentence_1()
    {
      string userInput1 = "my";
      string userInput2 = "My cat loves me.";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput1, userInput2);
      int output = newRepeatCounter.CountRepeats();
      int expectedOutput = 1;
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_CheckForNumberOfWordsInSentence_Number()
    {
      string userInput1 = "BIGGY";
      string userInput2 = "Biggy biggy bIgGy can't you see";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput1, userInput2);
      int output = newRepeatCounter.CountRepeats();
      int expectedOutput = 3;
      Assert.Equal(expectedOutput, output);
    }
  }
}
