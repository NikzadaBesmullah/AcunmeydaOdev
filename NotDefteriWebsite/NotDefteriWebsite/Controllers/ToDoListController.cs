using Microsoft.AspNetCore.Mvc;
using NotDefteriWebsite.Models;

namespace NotDefteriWebsite.Controllers
{
    public class ToDoListController : Controller
    {
        public IActionResult Index()
        {
            var todo = ToDoListRepo.GetToDoList();
            return View(todo);
        }
    }
}
