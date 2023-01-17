using Microsoft.AspNetCore.SignalR;
 namespace BlazorServerSignalRApp.Server.Hubs
 {
    public class ChatHub: Hubs
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("RecieveMessage", user, message);
        }
    }
 }