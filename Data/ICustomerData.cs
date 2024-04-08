namespace ConsoleApp2.Data
{
    public interface ICustomerData
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer?> GetCustomer(int id);
        Task<List<Customer>> GetCustomerByFilter(string filter);
        void UpdateCustomer(Customer customer);
        void AddCustomer(Customer customer);
        Task DeleteCustomer(int id);
    }
}
