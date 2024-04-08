using LinqToDB;

namespace ConsoleApp2.Data
{
    public class ProductData:IProductData
    {
        private readonly AppDbContext _context;

        public ProductData(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<Product>> GetProducts()
        {
            return _context.Products.ToListAsync();
        }
        public Task<Product?> GetProduct(int id)
        {
            return _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Product>> GetProductByFilter(string filter)
        {
            return _context.Products.Where(c => c.Name.Contains(filter) || c.Description.Contains(filter)).ToListAsync();
        }

        public void AddProduct(Product product)
        {
            _context.AddAsync(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public Task DeleteProduct(int id)
        {
            return _context.Products.DeleteAsync(c => c.Id == id);
        }
    }
}
