namespace ConsoleApp2.Data
{
    public interface IOrderData
    {
        Task<List<Order>> GetOrders();
        Task<Order?> GetOrder(int id);
        Task<List<Order>> GetOrderByFilter(int filter);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        Task DeleteOrder(int id);
    }
}
