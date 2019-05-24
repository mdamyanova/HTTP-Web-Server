namespace Demo.WebServer.Results
{
    using Demo.HTTP.Enums;
    using Demo.HTTP.Headers;
    using Demo.HTTP.Responses;

    public class InlineResourceResult: HttpResponse
    {
        public InlineResourceResult(byte[] content, HttpResponseStatusCode responseStatusCode)
            : base(responseStatusCode)
        {
            this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentLength, content.Length.ToString()));
            this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentDisposition, "inline"));
            this.Content = content;
        }
    }
}