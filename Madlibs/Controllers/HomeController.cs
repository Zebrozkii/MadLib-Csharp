using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/madlib")]
    public ActionResult MadLib(string noun, string adjective, string verb)
    {
      MadlibsVariable myMadlibsVariable = new MadlibsVariable();
      myMadlibsVariable.SetNoun(noun);
      myMadlibsVariable.SetAdjective(adjective);
      myMadlibsVariable.SetVerb(verb);
      return View(myMadlibsVariable);
    }

    [Route("/ass")]
    public ActionResult ass(string noun, string adjective, string verb)
    {
      MadlibsVariable myMadlibsVariable = new MadlibsVariable();
         myMadlibsVariable.SetNoun(noun);
         myMadlibsVariable.SetAdjective(adjective);
         myMadlibsVariable.SetVerb(verb);
         return View(myMadlibsVariable);
    }
  }
}
