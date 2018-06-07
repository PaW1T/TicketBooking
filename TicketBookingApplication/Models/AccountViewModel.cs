using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.Models
{
    public class AccountViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 6,ErrorMessage = "Длина от 6 до 20 символов")]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Длина от 6 до 20 символов")]
        public string Password { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage ="Возраст от 0 до 100")]
        public int Age { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
    }
}