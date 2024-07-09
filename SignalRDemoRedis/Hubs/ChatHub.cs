using Microsoft.AspNet.SignalR;
namespace SignalRDemoRedis.Hubs
{
    public class ChatHub
    {
        public void Send(string message)
        {
            Clients.All.messageReceived(message);
        }
    }
}
