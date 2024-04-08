namespace ConsoleApp2.Data
{
    public interface IProductData
    {
        Task<List<Product>> GetProducts();
        Task<Product?> GetProduct(int id);
        Task<List<Product>> GetProductByFilter(string filter);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Task DeleteProduct(int id);
    }
}
