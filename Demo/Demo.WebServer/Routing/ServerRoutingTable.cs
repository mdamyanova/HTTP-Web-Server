namespace Demo.WebServer.Routing
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using HTTP.Enums;
    using Demo.HTTP.Requests.Contracts;
    using Demo.HTTP.Responses.Contracts;

    public class ServerRoutingTable : IServerRoutingTable
    {
        private readonly Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>> routes;

        public ServerRoutingTable()
        {
            this.routes = new Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>>
            {
                [HttpRequestMethod.Get] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Post] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Put] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Delete] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>()
            };
        }

        public void Add(HttpRequestMethod method, string path, Func<IHttpRequest, IHttpResponse> func)
        {
            this.routes[method].Add(path.ToLower(), func);
        }

        public bool Contains(HttpRequestMethod requestMethod, string path)
        {
            return this.routes.ContainsKey(requestMethod) &&
                   this.routes[requestMethod].ContainsKey(path.ToLower());
        }

        public Func<IHttpRequest, IHttpResponse> Get(HttpRequestMethod requestMethod, string path)
        {
            return this.routes[requestMethod][path.ToLower()];
        }
    }
}