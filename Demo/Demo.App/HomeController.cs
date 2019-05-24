namespace Demo.App
{
    using Demo.HTTP.Enums;
    using Demo.HTTP.Requests.Contracts;
    using Demo.HTTP.Responses.Contracts;
    using Demo.WebServer.Results;

    public class HomeController
    {
        public IHttpResponse Index(IHttpRequest request)
        {
            string content = "<h1>Hello, World!</h1>";

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}