using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Ultilities
{
    public class PhoneNumberValidate : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            try
            {
                int sdt = Convert.ToInt32(value.ToString());
                return true;
            }
            catch (Exception ee)
            {
                return false;
            }
        }
    }
}
