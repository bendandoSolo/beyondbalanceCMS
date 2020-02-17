using System.ComponentModel.DataAnnotations;

namespace MalcolmWall.Models
{
    public class Email 
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        //[Display(Name = "Number")]
        //public string Number { get; set; }
        [Display(Name = "Subject")]
        //[Required(ErrorMessage = "Please enter a subject.")]
        public string Subject { get; set; }

        [Display(Name = "EmailAddress")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [RegularExpression(@"^[\w-\._+%]+@(?:[\w]+\.)+[\w]{2,6}$", ErrorMessage = "Email is not valid")]
        //[RegularExpression(@"\b[A - Z0 - 9._ % +-] +@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email is not valid")]
        //[RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Email is not valid")]
        public string EmailAddress { get; set; }

        [Display(Name = "Enquiry")]
        [Required(ErrorMessage = "Please describe the nature of your enquiry.")]
        public string Enquiry { get; set; }

    }
}