using System;
using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email Address")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter your Phone Number")]

        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Specify Wheter You'll Attend")]

        public bool WillAttend { get; set; }
        
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}