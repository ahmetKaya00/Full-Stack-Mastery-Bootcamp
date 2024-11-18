using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers{

    public class BootcampController : Controller{

        public IActionResult Index(){

            var bootcamp = new Bootcamp();

            bootcamp.Id = 1;
            bootcamp.Title = "Aspnet Core Bootcamp";
            bootcamp.Description = "Aspnet Core Bootcampi başladı ve devam ediyor";
            bootcamp.Image = "1.png";
            return View(bootcamp);
        }
        public IActionResult List(){

            var bootcamps = new List<Bootcamp>(){
                new Bootcamp(){Id = 1, Title = "Aspnet Core Bootcamp", Description = "Aspnet Core Bootcampi başladı ve devam ediyor",Image = "1.png"},
                new Bootcamp(){Id = 2, Title = "Full Stack Bootcamp", Description = "Full Stack Bootcamp başladı ve devam ediyor",Image = "2.png"},
                new Bootcamp(){Id = 3, Title = "Game Bootcamp", Description = "Game Bootcamp başladı ve devam ediyor",Image = "3.jpg"}
            };
            return View(bootcamps);
        }
    }
}