using Evaluaion1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Evaluaion1.Controllers
{
    
    public class PersonController : Controller
    {
        public IActionResult GetPerson()
        {
            var person = new PersonModel
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Edad = 33
            };
            
            return View("Index", person);
        }
    }
}
