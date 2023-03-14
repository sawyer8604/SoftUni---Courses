using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
    public class Validator
    {

        public static bool IsValid(object obj) // Person name, age
        {
            PropertyInfo[] propertyInfo = obj.GetType()
                .GetProperties()
                .Where(x => x.GetCustomAttributes(typeof(MyValidationAttribute)).Any())
                .ToArray();

            foreach (var property in propertyInfo)
            {
                object value = property.GetValue(obj);

                MyValidationAttribute attribute = property
                    .GetCustomAttribute<MyValidationAttribute>();

                bool IsValid = attribute.IsValid(value);

                if(!IsValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
