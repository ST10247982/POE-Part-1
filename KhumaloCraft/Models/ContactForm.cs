using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models
{
    public class ContactForm
    {
		[Required(ErrorMessage = "Name is required")]
		[RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Name must only contain letters")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Surname is required")]
		[RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Surname must only contain letters")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Email address is required")]
		[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
		public string EmailAddress { get; set; }

		[Required(ErrorMessage = "Subject is required")]
		public string Subject { get; set; }

		[Required(ErrorMessage = "Body is required")]
		public string Body { get; set; }
	}
}
