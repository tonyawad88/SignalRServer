
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SampleSignalRServer
{
    public class Chat : Hub
    {
        public Task SendToAll(string message, string message2)
        {
            return Clients.All.SendAsync("SendToAll", message, message2);
        }
        
        
    }
}