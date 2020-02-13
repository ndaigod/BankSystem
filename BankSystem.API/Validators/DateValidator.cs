using System.ComponentModel.DataAnnotations;

namespace BankSystem.API.Validators
{
    public class DateValidator: ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return "Date value should be in format \"DD.MM.YYYY\"";
        }

        protected override ValidationResult IsValid(object objValue, ValidationContext validationContext)
        {
            var dateValue = objValue as string;
            System.DateTime temp;
            if ((System.DateTime.TryParseExact(dateValue, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out temp)) == false)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }
    }
}