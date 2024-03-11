using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_ErrorHandling
{
    internal class DayInputError : UserError
    {
        public override string UEMessage()
        {
            return "Backdating is not allowed. Please choose a valid date.";
        }

        public override string ToString() => string.Format("{0,-30} {1}", "DayInputError:", UEMessage());

    }
}
