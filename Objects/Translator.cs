using System.Collections.Generic;
namespace Leetspeak.Objects
{
  public class Translator
  {
    private string _phrase;
    private string _userString;

    public Translator(string phrase)
    {
      _phrase = phrase;
      _userString = phrase;
    }
    public string Translate()
    {
      string _userString = _phrase.Replace("e","3").Replace("E","3").Replace("o", "0").Replace("O","0").Replace("I", "1");

      char[] chars = _userString.ToCharArray();
      for(int i = 1; i < chars.Length; i++)
      {
        if (chars[i] == 's')
        {
          if (chars[i-1] != ' ')
          {
            chars[i] = 'z';
          }
        }
        else if (chars[i] == 'S')
        {
          if (chars[i-1] != ' ')
          {
            chars[i] = 'Z';
          }
        }

      }

      _userString = string.Join("", chars);
      return _userString;
    }

  }
}
