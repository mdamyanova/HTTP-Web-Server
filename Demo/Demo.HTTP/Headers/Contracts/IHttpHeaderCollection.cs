﻿namespace Demo.HTTP.Headers.Contracts
{
    public interface IHttpHeaderCollection
    {
        void AddHeader(HttpHeader header);

        bool ContainsHeader(string key);

        HttpHeader GetHeader(string key);
    }
}