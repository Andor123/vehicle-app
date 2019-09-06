using System.ComponentModel.DataAnnotations;

namespace RazorPagesContacts.Data 
{
    public class Users 
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(20)]
        public string Password { get; set; }
    }
}