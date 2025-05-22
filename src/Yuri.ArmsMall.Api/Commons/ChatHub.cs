using Microsoft.AspNetCore.SignalR;
using Volo.Abp.DependencyInjection;

namespace Yuri.ArmsMall.Commons;

/// <summary>
/// 
/// </summary>
public class ChatHub : Hub, ITransientDependency
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="user"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public async Task BroadcastMessage(string message)
    {
        await Clients.All.SendAsync("ReceiveBroadcast", message);
    }
}
