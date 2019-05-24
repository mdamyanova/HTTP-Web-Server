namespace Demo.App
{
    using Demo.HTTP.Enums;
    using Demo.WebServer;
    using Demo.WebServer.Routing;
    using Demo.WebServer.Routing.Contracts;

    public class Launcher
    {
        public static void Main()
        {
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add(HttpRequestMethod.Get, "/", request => new HomeController().Index(request));

            Server server = new Server(8000, serverRoutingTable);

            server.Run();
        }
    }
}