using Microsoft.AspNetCore.Mvc;
using RPGCoolGuy.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace RPGCoolGuy.Controllers
{
    public class HomeController : Controller
    {
       private CharacterDBContext context {  get; set; }
        
       public HomeController(CharacterDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var characters = this.context.Characters.OrderBy(c => c.Name).ToList();
            return View(characters);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("CharacterForm");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var c = context.Characters.Find(id);
            return View("CharacterForm", c);
        }
        [HttpPost]
        public IActionResult Edit(Character c)
        {
            if (ModelState.IsValid)
            {
                if (c.Id == 0)
                {
                    context.Characters.Add(c);
                }
                else
                {
                    context.Characters.Remove(c);
                }
                context.SaveChanges();
                var chars = context.Characters.ToList();
                return View("Index", chars);
            }
            else 
            {
                return View("CharacterForm",c);
            }
           
        }
        public IActionResult Delete(int id)
        {
            Character del = context.Characters.Find(id);
            context.Characters.Remove(del);
            context.SaveChanges();
            var c = context.Characters.ToList();
            return View("Index", c);
        }
        [HttpGet]
        public IActionResult Fight()
        {
            ViewBag.Characters = context.Characters.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Fight(Fight fight)
        {
            Character c1 = context.Characters.Find(fight.Character1);
            Character c2 = context.Characters.Find(fight.Character2);
            if(c1.Attack > c2.Attack)
            {
                ViewBag.result = c1.Name;
            }
            else if (c2.Attack > c1.Attack)
            {
                ViewBag.result = c2.Name;
            }
            else
            {
                ViewBag.result = "Tie";
            }

            return View("Result");
        }
    }
}
