using System.ComponentModel.DataAnnotations;

namespace _01_Identity_IndividualAccounts.Models
{
    public class UserProfileEntity
    {
        [Key]
        public string UserId { get; set; } = null!;

        [Required(ErrorMessage = "Ange förnamn")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Ange efternamn")]
        public string LastName { get; set; } = null!;
    }
}
