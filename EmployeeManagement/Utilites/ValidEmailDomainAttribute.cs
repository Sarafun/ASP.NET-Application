﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Utilites
{
    public class ValidEmailDomainAttribute:ValidationAttribute
    {
        private readonly string allowedDomain;

        public ValidEmailDomainAttribute(string allowedDomain)
        {
            this.allowedDomain = allowedDomain;
        }

        public override bool IsValid(object value)
        {
            //string[] strings= value.ToString().Split('@');
            //return strings[1].ToUpper() == allowedDomain.ToUpper();
            return base.IsValid(value);
        }
    }
}
