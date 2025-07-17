
using System.ComponentModel.DataAnnotations;
namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please use a Name >= 3 letters."), MaxLength(100, ErrorMessage = "Please use a Name <= 100 letters.")]
        public string Name { get; set; }

        [Required, MinLength(5, ErrorMessage = "Please use an Address >= 5 letters."), MaxLength(100, ErrorMessage = "Please use an Address <= 100 letters.")]
        public string Line1 { get; set; }

        [MaxLength(100)]
        public string Line2 { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please use a Suburb/Locality >= 3 letters."), MaxLength(50, ErrorMessage = "Please use a Suburb/Locality <= 50 letters.")]
        public string Suburb { get; set; }

        [Required, MinLength(2, ErrorMessage = "Please use a State/Territory >= 2 letters."), MaxLength(3, ErrorMessage = "Please use a State/Territory <= 3 letters.")]
        public string State { get; set; }

        [Required, RegularExpression(@"^([0-9]{4})$", ErrorMessage = "Please use a valid Postal Code with four numbers.")]
        public string PostalCode { get; set; }

        public string GetAddress()
        {
            return $"{Name}, {Line1}, {(string.IsNullOrEmpty(Line2) ? "" : Line2 + ", ") }{Suburb}, {State} {PostalCode}";
        }
        
    }
}
