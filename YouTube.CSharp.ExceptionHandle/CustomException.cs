namespace YouTube.CSharp.ExceptionHandle
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }

    public class CustomDivideByZero : DivideByZeroException
    {
        public CustomDivideByZero(string? message, CustomException? innerException) : base(message, innerException)
        {
        }
    }
}
