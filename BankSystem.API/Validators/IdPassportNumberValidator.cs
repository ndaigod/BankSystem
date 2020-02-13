using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BankSystem.API.Validators
{
    public class IdPassportNumberValidator: ValidationAttribute
    {
        string pattern = @"([0-9]){7}([A-Z]){1}([0-9]){3}([A-Z]){2}([0-9]){1}";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (Regex.IsMatch(value.ToString(), pattern))
            {
                return ValidationResult.Success;
            }


            return new ValidationResult("Please enter a correct value");
        }
    }
}