using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Ultilities
{
    public class EmailValidateAttribute : ValidationAttribute
    {
        private readonly string allowedDomain;
        public EmailValidateAttribute(string allowedDomain)
        {
            this.allowedDomain = allowedDomain;
        }

        public override bool IsValid(object value)
        {
            string[] arrs = value.ToString().Split('@');
            return arrs[1].ToUpper() == allowedDomain.ToUpper();
        }
    }
}
