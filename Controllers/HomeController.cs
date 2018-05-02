namespace FriendLetter.Controllers
{
    public class HomeController : Controller

  {
        [Route("/")]
        public ActionResult Hello()
        {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient("Jessica");
          return View(myLetterVariable);
        }
    }
  }
}
