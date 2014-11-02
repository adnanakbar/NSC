using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Web.Models
{
    public class SequenceNumber
    {
        [Required(ErrorMessage = "Please enter a value")]
        [RegularExpression(@"^[0-9][0-9]*$", ErrorMessage = "Please enter positive whole numbers only")]
        public string Number { get; set; }

        public string ActionName { get; set; }

        public string ButtonName { get; set; }


    }
}