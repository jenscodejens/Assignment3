namespace Assignment3_ErrorHandling
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }

        public override string ToString() => string.Format("{0,-30} {1}", "NumericInputError:", UEMessage());
    }
}
