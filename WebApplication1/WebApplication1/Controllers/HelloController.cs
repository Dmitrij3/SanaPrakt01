using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        public ActionResult Index()
        {
            Name Con = new Name ("");
            return View(Con);
        }
        public ActionResult Welcome(string FirstName)
        {
            Name Con = new Name(FirstName);
            return View(Con);
        }
    }
}