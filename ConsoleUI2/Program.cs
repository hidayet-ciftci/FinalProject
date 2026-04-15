using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            productManager.Add(new Product { CategoryId = 1, ProductName = "sa" });
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("DI dependency Injection Mantığı!!");
            Console.WriteLine("Alltaki productlar sıkı sıkıya bağlı");
            Console.WriteLine("tight couple -> ürün değiştiği zaman ya da kural , bağlanma şekli manager değiştirmek gerekir");
            Console.WriteLine("Ama üstteki DI ile bağlandığı zaman içerisine yeni instance göndermek yeterli");
            productManager.WrongAdd(new Product { CategoryId = 1, ProductName = "sa" });
            foreach (var pro in productManager.WrongGetAll())
            {
                Console.WriteLine(pro.ProductName);
            }
        }
    }
}