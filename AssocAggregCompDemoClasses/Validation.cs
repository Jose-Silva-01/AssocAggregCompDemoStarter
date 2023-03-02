using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssocAggregCompDemoClasses
{
    internal static class Validation
    {
        public static bool ValidateLengthGreaterThan2(string value)
        {
            return value.Length > 2;
        }
    }
}
