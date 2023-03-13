using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttrbiutesAndReflection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = false)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
