namespace Demo.WebServer.Results
{
    using System;
    using System.Text;

    using HTTP.Enums;
    using HTTP.Headers;
    using HTTP.Responses;

    public class InternalServerErrorResult : HttpResponse
    {
        private const string DefaultErrorHeading = "<h1>Internal Server Error occured, see details</h1>";

        public InternalServerErrorResult(string content)
            : base(HttpResponseStatusCode.InternalServerError)
        {
            content = DefaultErrorHeading + Environment.NewLine + content;
            this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentType, "text/html"));
            this.Content = Encoding.UTF8.GetBytes(content);
        }
    }
}