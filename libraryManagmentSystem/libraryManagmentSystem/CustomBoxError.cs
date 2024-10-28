
namespace libraryManagmentSystem
{
    internal class CustomBoxError : Exception
    {
        public CustomBoxError()
        {
        }

        public CustomBoxError(string? message) : base(message)
        {
        }

        public CustomBoxError(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}