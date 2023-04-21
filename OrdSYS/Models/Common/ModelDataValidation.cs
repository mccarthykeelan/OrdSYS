using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrdSYS.Models.Common
{
    public class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMessage = string.Empty;
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, validationResults, true);
            if (isValid == false)
            {
                foreach (var item in validationResults)
                    errorMessage += "- " + item.ErrorMessage + "\n";
                throw new Exception(errorMessage);
            }
        }
    }
}
