namespace Demo.WebServer.Results
{
    using System.Text;

    using HTTP.Enums;
    using HTTP.Headers;
    using HTTP.Responses;

    public class TextResult : HttpResponse
    {
        public TextResult(string content, HttpResponseStatusCode responseStatusCode, 
            string contentType = "text/plain; charset=utf-8") 
            : base(responseStatusCode)
        {
            this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentType, contentType));
            this.Content = Encoding.UTF8.GetBytes(content);
        }
        
        public TextResult(byte[] content, HttpResponseStatusCode responseStatusCode, 
            string contentType = "text/plain; charset=utf-8")
            : base(responseStatusCode)
        {
            this.Content = content;
            this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentType, contentType));
        }
    }
}