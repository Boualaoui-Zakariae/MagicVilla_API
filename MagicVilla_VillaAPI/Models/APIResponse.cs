using System;
using System.Net;

namespace MagicVilla_VillaAPI.Models
{
	public class APIResponse
	{
        public APIResponse()
        {
            ErrorMessages = new List<string>();
        }

        private HttpStatusCode statusCode;

        public HttpStatusCode StatusCode
        {
            get { return statusCode; }
            set
            {
                statusCode = value;
                IsSuccess = (statusCode >= HttpStatusCode.OK && statusCode <= HttpStatusCode.PartialContent);
            }
        }

        public bool IsSuccess { get; private set; }
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}

