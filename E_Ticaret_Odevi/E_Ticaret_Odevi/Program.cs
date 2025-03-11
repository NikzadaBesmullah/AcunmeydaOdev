using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Ticaret_Odevi.Models;

namespace E_Ticaret_Odevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("E-Ticaret Sistemi");
            Console.WriteLine("------------------------\n");

            // ÖRNEK 1: Temel Alışveriş Süreci
            Console.WriteLine("ÖRNEK 1: Temel Alışveriş Süreci");
            Console.WriteLine("---------------------------------");

            // Ürünler oluştur
            Products laptop = new Products(1, "Laptop", 5000, 10);
            Products telefon = new Products(2, "Telefon", 3000, 20);
            Products kulaklık = new Products(3, "Kulaklık", 500, 50);

            // Satıcı oluştur
            Seller seller = new Seller(1, "Ali", "ali@mail.com", "TechMarket");
            seller.AddProduct(laptop);
            seller.AddProduct(telefon);
            seller.AddProduct(kulaklık);

            // Müşteri oluştur
            Customers customer = new Customers(1, "Ayşe", "ayse@mail.com", "İstanbul");

            // Sepete ekle
            customer.AddToCart(laptop, 1);
            customer.AddToCart(telefon, 1);

            // Ödeme yöntemi
            IPayment payment = new CreditCardPayment("1234", "Ayşe");

            // Siparişi tamamla
            Order order = customer.Checkout(payment);

            Console.WriteLine($"Sipariş oluşturuldu. Toplam: {order.TotalAmount} TL");
            Console.WriteLine($"Kalan laptop stok: {laptop.Stock}");
            Console.WriteLine($"Kalan telefon stok: {telefon.Stock}");

            Console.WriteLine("\n");

            // ÖRNEK 2: Farklı Ödeme Yöntemleri
            Console.WriteLine("ÖRNEK 2: Farklı Ödeme Yöntemleri");
            Console.WriteLine("--------------------------------");

            Customers customer2 = new Customers(2, "Mehmet", "mehmet@mail.com", "Ankara");
            customer2.AddToCart(kulaklık, 2);

            // Kredi kartı ile ödeme
            IPayment creditCard = new CreditCardPayment("5678", "Mehmet");
            Order order2 = customer2.Checkout(creditCard);
            Console.WriteLine($"Kredi kartı ile sipariş tamamlandı. Toplam: {order2.TotalAmount} TL");

            // Havale ile ödeme
            customer2.AddToCart(kulaklık, 1);
            IPayment bankTransfer = new BankTansferPayment("Ziraat", "TR123456");
            Order order3 = customer2.Checkout(bankTransfer);
            Console.WriteLine($"Havale ile sipariş tamamlandı. Toplam: {order3.TotalAmount} TL");
            Console.WriteLine($"Kalan kulaklık stok: {kulaklık.Stock}");

            Console.WriteLine("\n");

            // ÖRNEK 3: Satıcı İşlemleri
            Console.WriteLine("ÖRNEK 3: Satıcı İşlemleri");
            Console.WriteLine("-------------------------");

            // Yeni satıcı ve ürünler
            Seller seller2 = new Seller(2, "Zeynep", "zeynep@mail.com", "Z Butik");
            Products tshirt = new Products(4, "T-Shirt", 150, 100);
            Products pantolon = new Products(5, "Pantolon", 300, 50);

            seller2.AddProduct(tshirt);
            seller2.AddProduct(pantolon);

            Console.WriteLine($"Satıcı bilgisi: {seller2.GetUserInfo()}");
            Console.WriteLine("Satıcının ürünleri:");
            foreach (var product in seller2.Products)
            {
                Console.WriteLine($"- {product.Name}: {product.Price} TL, Stok: {product.Stock}");
            }

            // Ürün güncelleme
            pantolon.Price = 350; 
            tshirt.Stock += 50;   

            Console.WriteLine("\nGüncellenen ürünler:");
            foreach (var product in seller2.Products)
            {
                Console.WriteLine($"- {product.Name}: {product.Price} TL, Stok: {product.Stock}");
            }

            Console.WriteLine("\n");

            // ÖRNEK 4: Sepet İşlemleri
            Console.WriteLine("ÖRNEK 4: Sepet İşlemleri");
            Console.WriteLine("-----------------------");

            Customers customer3 = new Customers(3, "Fatma", "fatma@mail.com", "İzmir");
         
            // Sepete ürün ekleme
            customer3.AddToCart(tshirt, 2);
            customer3.AddToCart(pantolon, 1);
            customer3.AddToCart(kulaklık, 1);

            Console.WriteLine("Sepetteki ürünler:");
            double total = 0;
            foreach (var item in customer3.ShoppingCart.Items)
            {
                double itemTotal = item.Key.Price * item.Value;
                Console.WriteLine($"- {item.Key.Name}: {item.Value} adet, {item.Key.Price} TL/adet, Toplam: {itemTotal} TL");
                total += itemTotal;
            }
            Console.WriteLine($"Sepet toplamı: {total} TL");

            // Sepeti temizleme
            customer3.ShoppingCart.ClearCart();
            Console.WriteLine("\nSepet temizlendi.");
            Console.WriteLine($"Sepetteki ürün sayısı: {customer3.ShoppingCart.Items.Count}");

            Console.WriteLine("\n");

            // ÖRNEK 5: Çoklu Müşteri ve Sipariş
            Console.WriteLine("ÖRNEK 5: Çoklu Müşteri ve Sipariş");
            Console.WriteLine("--------------------------------");

            // Müşteriler
            List<Customers> customers = new List<Customers>
            {
                new Customers(4, "Ahmet", "ahmet@mail.com", "Bursa"),
                new Customers(5, "Merve", "merve@mail.com", "Antalya"),
                new Customers(6, "Emre", "emre@mail.com", "Trabzon")
            };

            // Siparişler
            foreach (var cust in customers)
            {
                cust.AddToCart(tshirt, 1);
                if (cust.Id % 2 == 0) 
                {
                    cust.AddToCart(kulaklık, 1);
                }

                IPayment payMethod = cust.Id % 2 == 0
                    ? (IPayment)new CreditCardPayment("1111", cust.Name)
                    : new BankTansferPayment("Halk", "TR" + cust.Id + "54321");

                Order custOrder = cust.Checkout(payMethod);

                string paymentType = payMethod is CreditCardPayment ? "Kredi Kartı" : "Havale";
                Console.WriteLine($"Müşteri: {cust.Name}, Ödeme: {paymentType}, Tutar: {custOrder.TotalAmount} TL");
            }

            Console.WriteLine("\nProgram tamamlandı.");
        }
    }
    }
