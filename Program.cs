using ConsoleApp2.Data;
using LinqToDB.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinqToDBForEFTools.Initialize();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=shop;User Id=postgres;Password=afz9fGMdzau;");
 

            var _options = optionsBuilder.Options;
            var _db = new AppDbContext(_options);

            var customerData = new CustomerData(_db);
            var orderData = new OrderData(_db);
            var productData = new ProductData(_db);

        }
    }
}
