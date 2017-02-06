using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HtmlHelperLab.Models.CustomerValidation
{
    public class WordNum : ValidationAttribute
    {
        private readonly string _chars;
        // [Exclude ("^%$#@!")]

        public WordNum(string chars) : base("{0} exceed three words.")
        {
            _chars = chars;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Regex expression = new Regex(@_chars);
            //"[A-Za-z]*[ ]{1}[A-Za-z]*[ ]{1}[A-Za-z]*");
            if (expression.IsMatch(value.ToString()))
            {
                return ValidationResult.Success;
            }
            else {
                var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                return new ValidationResult(errorMessage);
            }
            
        }

    }
}