using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_ErrorHandling
{
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error";
        }
        
        public override string ToString() => string.Format("{0,-30} {1}", "TextInputError:", UEMessage());
        /*
         * Samma funktion som tidigare använd kod.
         *
         * public override string ToString(){
         * const string format = "{0,-12} {1}";
         * return string.Format(format, "TextInputError:", UEMessage());
         * return $"TextInputError: {UEMessage()}";
         * 
        */
    }
}


