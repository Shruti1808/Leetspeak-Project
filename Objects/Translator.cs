using System.Collections.Generic;
namespace Leetspeak.Objects
{
  public class Translator
  {
    private string _phrase;

    public Translator(string phrase)
    {
      _phrase = phrase;
    }
    public string Translate()
    {
      string userString = _phrase.Replace("e","3");
      return userString;
    }

  }
}
