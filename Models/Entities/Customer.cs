using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2
{
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("firstname")]
        public string FirstName { get; set; } = "";
        [Column("lastname")]
        public string LastName { get; set; } = "";
        [Column("age")]
        public int Age { get; set; }
    }
}
