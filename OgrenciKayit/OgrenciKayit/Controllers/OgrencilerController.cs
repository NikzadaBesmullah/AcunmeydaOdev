using System;
using Microsoft.AspNetCore.Mvc;
using OgrenciKayit.Models;
using System.Linq;

namespace OgrenciKayit.Controllers
{
    public class OgrencilerController : Controller
    {
        private readonly OgrDbContext _context;

        public OgrencilerController(OgrDbContext context)
        {
            _context = context;
        }

        // Öğrenci kayıt formu
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Öğrenci kaydetme işlemi
        [HttpPost]
        public IActionResult Create(Ogreciler student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Ogrenciler.Add(student); // Öğrenciyi veritabanına ekle
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "Öğrenci başarıyla kaydedildi."; // Başarı mesajı
                    return RedirectToAction("Listele"); // Listeleme sayfasına yönlendir
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Bir hata oluştu: {ex.Message}");
                }
            }
            return View(student); // Hatalı modelse formu tekrar göster
        }

        // Öğrenci listeleme sayfası
        public IActionResult Listele()
        {
            var ogrenciler = _context.Ogrenciler.ToList(); // Öğrencileri veritabanından al
            return View(ogrenciler); // Listeyi view'a gönder
        }

        // Öğrenci güncelleme sayfası
        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            var ogrenci = _context.Ogrenciler.Find(id);
            if (ogrenci == null)
            {
                return NotFound(); // Öğrenci bulunamadığında 404 sayfasına yönlendir
            }
            return View(ogrenci); // Öğrenciyi güncelleme formu ile getir
        }

        // Öğrenci güncelleme işlemi
        [HttpPost]
        public IActionResult Guncelle(Ogreciler ogrenci)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Ogrenciler.Update(ogrenci); // Öğrenciyi güncelle
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "Öğrenci başarıyla güncellendi."; // Başarı mesajı
                    return RedirectToAction("Listele"); // Güncelleme sonrası listeye yönlendir
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Bir hata oluştu: {ex.Message}");
                }
            }
            return View(ogrenci); // Hatalı modelse formu tekrar göster
        }

        // Öğrenci silme işlemi
        public IActionResult Sil(int id)
        {
            var ogrenci = _context.Ogrenciler.Find(id);
            if (ogrenci == null)
            {
                return NotFound(); // Öğrenci bulunamazsa hata döndür
            }

            try
            {
                _context.Ogrenciler.Remove(ogrenci); // Öğrenciyi veritabanından sil
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Öğrenci başarıyla silindi."; // Başarı mesajı
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Silme işlemi sırasında bir hata oluştu: {ex.Message}");
            }

            return RedirectToAction("Listele"); // Silme sonrası listeye yönlendir
        }
    }
}
