using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using WebApplication1_learning.Models;

namespace WebApplication1_learning.Controllers
{
    public class TestController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int age = 18)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["Age"] = age;

            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Suppose this is the repository to the database
            var person = new Person();
            person.Name = "John Wick";
            person.PhoneNumber = "0286765765";
            person.Email = "john.wick@gmail.com";

            return View(person);
        }
    }
}
