namespace Demo.WebServer.Results
{
    using HTTP.Headers;
    using HTTP.Responses;

    public class FileResult : HttpResponse
    {
        public FileResult(byte[] content)
        {
            this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentLength, content.Length.ToString()));
            this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentDisposition, "inline"));
            this.Content = content;
        }
    }
}