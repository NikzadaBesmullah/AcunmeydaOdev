using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NotDefteriWeb.Models;

namespace NotDefteriWeb.Controllers
{
    public class NoteController : Controller
    {
        public ActionResult index()
        {
            var n = new Note();
            n.Noteid = 1;
            n.NoteTitle = "İlk Notum";
            n.NoteContent = "Ağ temelleri Dersi için Cisco Eğitimini Tamamla";

            return View(n);
        }
        public ActionResult List()
        {
            var not = new List<Note>()
            {
            new Note() { Noteid = 2, NoteTitle = "İnglizce", NoteContent = "İnglizce Kursunu bitir" , NoteAddTime= new DateTime(2025,03,14) } ,
            new Note() { Noteid = 3, NoteTitle = "Acunmedya", NoteContent = "Asp net dersini tekrar et" , NoteAddTime= new DateTime(2025,1,05)} ,
            new Note() { Noteid = 4, NoteTitle = "Ağ Temelleri", NoteContent = "Slaytı Bitir" , NoteAddTime=DateTime.Now} ,

            };
            return View(not);
        }
    }
}
