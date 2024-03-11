using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_ErrorHandling
{
    internal class MusicGenreInputError : UserError
    {
        public override string UEMessage()
        {
            return "No one and I mean no one listen to redneck country music. Be ashamed";
        }

        public override string ToString() => string.Format("{0,-30} {1}", "MusicGenreInputError:", UEMessage());

    }
}
