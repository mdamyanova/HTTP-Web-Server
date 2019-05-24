namespace Demo.WebServer.Results
{
    using System;
    using System.Text;

    using HTTP.Enums;
    using HTTP.Headers;
    using HTTP.Responses;

    public class BadRequestResult : HttpResponse
    {
        private const string DefaultErrorHeading = "<h1>Error of type occured, see details</h1>";

        public BadRequestResult(string content, HttpResponseStatusCode seeOther)
            : base(HttpResponseStatusCode.BadRequest)
        {
            content = DefaultErrorHeading + Environment.NewLine + content;
            this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentType, "text/html"));
            this.Content = Encoding.UTF8.GetBytes(content);
        }
    }
}