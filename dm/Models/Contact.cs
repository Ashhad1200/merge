using System;
using System.ComponentModel.DataAnnotations;

namespace dm.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Company { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [DataType(DataType.PhoneNumber)]
        public double Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public string City { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
}
