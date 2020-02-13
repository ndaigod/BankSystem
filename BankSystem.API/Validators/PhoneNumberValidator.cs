using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BankSystem.API.Validators
{
    public class PhoneNumberValidator: ValidationAttribute
    {
        string mobilePhonePattern = @"\+[0-9]{3}\([0-9]{2}\)[0-9]{3}-[0-9]{2}-[0-9]{2}";
        string homePhonePattern = @"[0-9]{2,3}-[0-9]{2}-[0-9]{2}";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

        string phone = value.ToString();

        if (phone.Length == 17) {
            if (Regex.IsMatch(phone, mobilePhonePattern))
            {
                return ValidationResult.Success;
            }
        } else if ((phone.Length == 8) || (phone.Length == 9)) {
            if (Regex.IsMatch(phone, homePhonePattern))
            {
                return ValidationResult.Success;
            }
        }
        


        return new ValidationResult("Please enter a correct value");
        }
    }
}