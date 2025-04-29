using System.ComponentModel.DataAnnotations;

namespace UrunYonetim.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Ürün adı en fazla 100 karakter olabilir.")]
        public string Name { get; set; }

        [Range(1, 10000, ErrorMessage = "Fiyat 1 ile 10000 arasında olmalıdır.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stok bilgisi zorunludur.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stok 0 veya daha büyük olmalıdır.")]
        public int Stock { get; set; }

        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        public string SupplierEmail { get; set; }
    }
}
