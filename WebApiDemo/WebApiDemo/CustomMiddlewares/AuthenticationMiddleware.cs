using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDemo.CustomMiddlewares
{
    public class AuthenticationMiddleware
    {

        private readonly RequestDelegate _next;
        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;

        }

        public async Task Invoke(HttpContext context)
        {
            string authHeader = context.Request.Headers["Authorization"];

            if(authHeader!=null &&authHeader.StartsWith("basic",StringComparison.OrdinalIgnoreCase))
            {
                var token = authHeader.Substring(6).Trim();
                //basic engin:12345 6 dan itibaren batlar base64 formatı
                var credentialString = Encoding.UTF8.GetString(Convert.FromBase64String(token));

                var credentials = credentialString.Split(":");

                if(credentials[0] =="engin" && credentials[1]) == "12345")
                {
                    var claims = new
                }
            }



            await _next(context);
        }


    }
}
