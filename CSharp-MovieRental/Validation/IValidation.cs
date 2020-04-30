using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MovieRental.Validation
{
    interface IValidation
    {
        bool IsValid();
        IEnumerable<string> Validate();
    }
}
