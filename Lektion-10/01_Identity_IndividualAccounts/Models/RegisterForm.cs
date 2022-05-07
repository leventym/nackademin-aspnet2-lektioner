using System.ComponentModel.DataAnnotations;

namespace _01_Identity_IndividualAccounts.Models
{
    public class RegisterForm
    {
        [Required (ErrorMessage = "Ange förnamn")]
        public string FirstName { get; set; } = null!;
        
        [Required(ErrorMessage = "Ange efternamn")]
        public string LastName { get; set; } = null!;
        
        [Required(ErrorMessage = "Ange email")]
        [EmailAddress]
        public string Email { get; set; } = null!;
        
        [Required(ErrorMessage = "Ange lösenord")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        //För att dirigera användaren tillbaka till sidan som man kom in på
        public string ReturnUrl { get; set; } = "/";
    }
}
