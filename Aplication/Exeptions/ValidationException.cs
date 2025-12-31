using FluentValidation.Results;

namespace Exeptions
{
    [Serializable]
    internal class ValidationException : Exception
    {
        private List<ValidationFailure> failures;

        public ValidationException()
        {
        }

        public ValidationException(List<ValidationFailure> failures)
        {
            this.failures = failures;
        }

        public ValidationException(string? message) : base(message)
        {
        }

        public ValidationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}