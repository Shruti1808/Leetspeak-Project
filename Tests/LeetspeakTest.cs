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
    public void Translate_ForWordsWithE_ReplaceWith3()
    {
      string phrase02 = "Ear";
      Translator newTranslator = new Translator(phrase02);

      string result = newTranslator.Translate();

      Assert.Equal("3ar", result);
    }
    [Fact]
    public void Translate_ForWordsWithO_ReplaceWith0()
    {
      string phrase03 = "Out";
      Translator newTranslator = new Translator(phrase03);

      string result = newTranslator.Translate();

      Assert.Equal("0ut", result);
    }
    [Fact]
    public void Translate_ForWordsWithI_ReplaceWith1()
    {
      string phrase04 = "Initial";
      Translator newTranslator = new Translator(phrase04);

      string result = newTranslator.Translate();

      Assert.Equal("1nitial", result);
    }
    [Fact]
    public void Translate_ForWordsNotStartingWithS_ReplaceWithZ()
    {
      string phrase05 = "Styles and styles";
      Translator newTranslator = new Translator(phrase05);

      string result = newTranslator.Translate();

      Assert.Equal("Styl3z and styl3z", result);
    }
  }
}
