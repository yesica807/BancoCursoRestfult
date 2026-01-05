using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Wrappers
{
    public class Response<T>
    {
        public Response()
        {
            Errors = new List<string>();
            Message = string.Empty;
        }
        
        public Response(T data, string? message = null)
        {
            Succeeded = true;
            Message = message ?? string.Empty;
            Data = data;
            Errors = new List<string>();
        }
        
        public Response(string message)
        {
            Succeeded = false;
            Message = message;
            Errors = new List<string>();
        }
        
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; } = default!;
    }
}
