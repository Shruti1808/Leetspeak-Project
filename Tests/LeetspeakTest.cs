using Xunit;
using Leetspeak.Objects;
using System.Collections.Generic;
namespace Leetspeak
{
  public class LeetspeakTest
  {
    [Fact]
    public void Translate_ForWordsWithoutTranslation_PrintPhrase()
    {
      string phrase01 = "attack";
      Translator newTranslator = new Translator(phrase01);

      string result = newTranslator.Translate();

      Assert.Equal("attack", result);
    }
    [Fact]
    public void Translate_ForWordsWitE_ReplaceWith3()
    {
      string phrase02 = "ear";
      Translator newTranslator = new Translator(phrase02);

      string result = newTranslator.Translate();

      Assert.Equal("3ar", result);
    }
  }
}
