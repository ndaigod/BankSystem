using System.ComponentModel.DataAnnotations;
using BankSystem.API.Validators;
namespace BankSystem.API.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Patronymic { get; set; }

        [Required]
        [DateValidator]
        public System.DateTime Birthday { get; set; }

        [Required]
        public bool Sex { get; set; }

        [Required]
        [StringLength(2)]
        public string PassportSerie { get; set; }

        [Required]
        [StringLength(7)]
        public string PassportNumber { get; set; }

        [Required]
        public string IssuancePlace { get; set; }

        [Required]
        [DateValidator]
        public System.DateTime IssuanceDate { get; set; }

        [Required]
        [StringLength(14)]
        [IdPassportNumberValidator]
        public string IdPassportNumber { get; set; }

        [Required]
        public string BirthPlace { get; set; }

        [Required]
        public virtual LivingPlaceCity LivingPlaceCity { get; set; }

        [Required]
        public string LivingPlaceAddress { get; set; }

        [StringLength(9, MinimumLength = 8)]
        [PhoneNumberValidator]
        public string HomePhoneNumber { get; set; }

        [StringLength(17)]
        [PhoneNumberValidator]
        public string MobilePhoneNumber { get; set; }
        public string Email { get; set; }

        [Required]
        public virtual ResidencePermitCity ResidencePermitCity { get; set; }

        [Required]
        public virtual MaritalStatus MaritalStatus { get; set; }

        [Required]
        public virtual Nationality Nationality { get; set; }

        [Required]
        public virtual Disability Disability { get; set; }

        [Required]
        public bool Retired { get; set; }
        public decimal MoneyIncome { get; set; }

  }
}