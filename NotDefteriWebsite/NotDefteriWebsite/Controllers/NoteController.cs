using Microsoft.AspNetCore.Mvc;
using NotDefteriWebsite.Models;

namespace NotDefteriWebsite.Controllers
{
    public class NoteController : Controller
    {
        private readonly Repository _repository = new Repository();

        public IActionResult index()
        {
            
            return View(Repository._Not);
        }

        public IActionResult Goruntele(int id)
        {
            var not = new Note();
            return View(not);
            
        }

        public IActionResult Details(int id) 
        {
            var Note=Repository.GetByid(id);
            return View(Note);
        }
    }
}

