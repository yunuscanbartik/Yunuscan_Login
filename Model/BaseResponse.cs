using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Model
{
    public class BaseResponse
    {
        public HttpStatusCode? StatusCode { get; set; }
        public bool? Status { get; set; }
        public string? ErrorCode { get; set; }
        public string? ResponseMessage { get; set; }
    }
}
