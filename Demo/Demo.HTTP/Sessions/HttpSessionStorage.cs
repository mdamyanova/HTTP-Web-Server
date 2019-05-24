namespace Demo.HTTP.Sessions
{
    using System.Collections.Concurrent;

    using Contracts;

    public class HttpSessionStorage
    {
        public const string SessionCookieKey = "Demo_ID";

        private static readonly ConcurrentDictionary<string, IHttpSession> sessions
            = new ConcurrentDictionary<string, IHttpSession>();

        public static IHttpSession GetSession(string id)
        {
            return sessions.GetOrAdd(id, _ => new HttpSession(id));
        }
    }
}