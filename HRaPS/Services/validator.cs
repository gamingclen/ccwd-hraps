using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HRaPS.Services
{
    public class employee_validator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Say the first name can't contain a space,
            if (value.ToString().Length <= 0)
            {
                return new ValidationResult(false, "Can't be null or empty");
            }

            return ValidationResult.ValidResult;
        }
    }
}
