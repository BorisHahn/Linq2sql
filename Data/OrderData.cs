using LinqToDB;

namespace ConsoleApp2.Data
{
    public class OrderData:IOrderData
    {
        private AppDbContext _context;
        public OrderData(AppDbContext context) 
        { 
            _context = context;
        }

        public Task<List<Order>> GetOrders()
        {
            return _context.Orders.ToListAsync();
        }

        public Task<Order?> GetOrder(int id)
        {
            return _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Order>> GetOrderByFilter(int filter)
        {
            return _context.Orders.Where(o => o.Quantity == filter).ToListAsync();
        }

        public void AddOrder(Order order)
        {
            _context.AddAsync(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public Task DeleteOrder(int id)
        {
            return _context.Orders.DeleteAsync(c => c.Id == id);
        }
    }
}
