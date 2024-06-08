using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    private static readonly Dictionary<string, string> _userConnections = new();

    public async Task SendMessage(string sender, string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", sender, user, message);
    }
}