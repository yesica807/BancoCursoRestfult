using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Exceptions
{
    public class ValidationExeption : Exception
    {
        public ValidationExeption() : base("Se han Producido uno o mas errores de validacion")
        {
            Errors = new List<string>();
        }
        public List<string>Errors { get; }
        public ValidationExeption(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }
    }
}
