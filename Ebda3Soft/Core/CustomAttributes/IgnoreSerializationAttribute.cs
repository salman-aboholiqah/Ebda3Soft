using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.CustomAttributes
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class IgnoreSerializationAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        // This is a positional argument
        public IgnoreSerializationAttribute()
        {
            // TODO: Implement code here

        }
        // This is a named argument
        public int NamedInt { get; set; }
    }
}
