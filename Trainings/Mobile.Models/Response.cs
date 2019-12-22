using System;
using System.Text;
using System.Collections.Generic;

namespace Mobile.Models
{
    public class Response<T>
    {
        public bool Status { get; set; } = true;
        public T Result { get; set; }
        public Response(T result)
        {
           this.Result = result;
        }
    } 

    public class Status
    {

    }
}
