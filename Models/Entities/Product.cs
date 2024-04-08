using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2
{
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = "";
        [Column("description")]
        public string Description { get; set; } = "";
        [Column("stockquantity")]
        public int StockQuantity { get; set; }
        [Column("price")]
        public int Price {  get; set; }
    }
}
