using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET5.Models
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("fist_name")]
        public string FistName { get; set; }
        [Column("second_name")]
        public string LastName { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}
