using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCJShop.Validation
{
    public class RequiredCollectionAttribute : ValidationAttribute
    {
        public override bool IsValid(object value) => value is IList list && list.Count > 0;
    }
}
