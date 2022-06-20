using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Gateway
{
    
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;
        
        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string authHeader = httpContext.Request.Headers["Authorization"];
            if (authHeader != null)
            {
                string auth = authHeader.Split(new char[] { ' ' })[1];
                Encoding encoding = Encoding.GetEncoding("UTF-8");
                var UnamePwd = encoding.GetString(Convert.FromBase64String(auth));
                string uName = UnamePwd.Split(new char[] { ':' })[0];
                string pwd = UnamePwd.Split(new char[] { ':' })[1];

                if (uName == "" && pwd == "")
                { await _next(httpContext); }
                else
                {
                    httpContext.Response.StatusCode = 401;
                    throw new AppException("Invalid creds");
                    
                }
            }
            else { 
                httpContext.Response.StatusCode = 401;
                throw new AppException("Invalid creds");
                 }
        }
    }

    public static class BasicAuthMiddlewareExtension
    {
        public static IApplicationBuilder UseBasicAuth(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<AuthMiddleware>();
        }
    }
}
