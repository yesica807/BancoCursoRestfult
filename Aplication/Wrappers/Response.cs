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

        }
        public Response(T data, string message = null)
        {
            succeded = true;
            message = message;
            Data = Data;
        }
        public Response(string message)
        {
            succeded = false;
            message = message;
        }
        public bool succeded { get; set; }
        public string message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }

    }
}
