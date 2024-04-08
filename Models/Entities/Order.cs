using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2
{
    public class Order
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("customerid")]
        public int CustomerId { get; set; }
        [Column("productid")]
        public int ProductId { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
