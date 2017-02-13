using Nancy;
using System.Collections.Generic;
using Leetspeak.Objects;

namespace Leetspeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        string userInput = Request.Form["phrase"];
        Translator newTranslator = new Translator(userInput);
        string output = newTranslator.Translate();
        return View["results.cshtml", output];
      };
    }
  }
}
