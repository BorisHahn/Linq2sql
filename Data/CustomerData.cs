using LinqToDB;

namespace ConsoleApp2.Data
{
    public class CustomerData : ICustomerData
    {
        private readonly AppDbContext _context;
        public CustomerData(AppDbContext context)
        {
            _context = context;
        }
        public Task<List<Customer>> GetCustomers()
        {
            return _context.Customers.ToListAsync();
        }
        public Task<Customer?> GetCustomer(int id)
        {
            return _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Customer>> GetCustomerByFilter(string filter)
        {
            return _context.Customers.Where(c => c.FirstName.Contains(filter) ||  c.LastName.Contains(filter)).ToListAsync();
        }

        public void AddCustomer(Customer customer)
        {
            _context.AddAsync(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public Task DeleteCustomer(int id)
        {
            return _context.Customers.DeleteAsync(c => c.Id == id).ContinueWith(x =>
            {
                _context.SaveChanges();
            });
        }
    }
}
