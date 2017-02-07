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
        private readonly int _max;
        // [Exclude ("^%$#@!")]

        public WordNum(int num) : base("{0} exceed three words.")
        {
            _max = num;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //Regex expression = new Regex(@_chars);
            //"[A-Za-z]*[ ]{1}[A-Za-z]*[ ]{1}[A-Za-z]*");

            if (value != null)
            {

                int num = value.ToString().Split(' ').Count();
                if (num > _max)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;

        }

    }
}