using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3_ErrorHandling
{
    internal abstract class UserError
    {
        public abstract string UEMessage();

        //public override string ToString() => string.Format("{0,-12} {1}", UEMessage());
    }
}

