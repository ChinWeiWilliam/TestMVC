using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class login
    {
        public login()
        {
            Account = string.Empty;
            Password = string.Empty;
        }
        [Required(ErrorMessage ="  * Please enter your Account!")]
        [Display(Name ="Account")]
        public string Account {  get; set; }
        [Required(ErrorMessage ="  * Please enter your Password!")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }
    }
}
