using Microsoft.AspNetCore.Mvc;
using NotDefteriWebsite.Models;

namespace NotDefteriWebsite.Controllers
{
    public class NoteController : Controller
    {

        public ActionResult index()
        {
            var not = new List<Note>()
            {
            new Note() { Noteid = 2, NoteTitle = "İnglizce", NoteContent = "İnglizce Kursunu bitir" , NoteAddTime= new DateTime(2025,03,14), NoteCategory="Dil" } ,
            new Note() { Noteid = 3, NoteTitle = "Acunmedya", NoteContent = "Asp net dersini tekrar et" , NoteAddTime= new DateTime(2025,1,05),NoteCategory="Staj"} ,
            new Note() { Noteid = 4, NoteTitle = "Ağ Temelleri", NoteContent = "Slaytı Bitir" , NoteAddTime=DateTime.Now,NoteCategory="okul"} ,

            };
            return View(not);
        }
        
        }
    }

