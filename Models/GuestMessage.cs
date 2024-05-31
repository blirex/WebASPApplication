using System.ComponentModel.DataAnnotations;

namespace WebASPApplication1.Models
{
    public class GuestMessage
    {
        public int Id { get; set; }

        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage ="Please, input valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please, input valid Fio")]
        public string Fio {  get; set; }

        [Required(ErrorMessage = "Please, input valid Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please, input valid Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please, input valid Message")]
        public string Message { get; set; }
    }
}
