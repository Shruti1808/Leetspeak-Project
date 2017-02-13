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
    }
  }
}
