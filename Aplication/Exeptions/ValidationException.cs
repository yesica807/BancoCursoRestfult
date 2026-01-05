using FluentValidation.Results;

namespace Exeptions
{
    [Serializable]
    public class ValidationException : Exception
    {
        public List<ValidationFailure> Failures { get; set; } = new List<ValidationFailure>();

        public ValidationException()
        {
        }

        public ValidationException(List<ValidationFailure> failures)
        {
            Failures = failures;
        }

        public ValidationException(string? message) : base(message)
        {
        }

        public ValidationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}