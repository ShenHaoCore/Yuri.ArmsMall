using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using Volo.Abp.DependencyInjection;

namespace Yuri.ArmsMall.Hubs;

/// <summary>
/// 
/// </summary>
[Authorize]
public class ChatHub : Hub, ITransientDependency
{
    /// <summary>
    /// 客户端发送消息到服务器
    /// </summary>
    /// <param name="user"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    /// <summary>
    /// 广播消息给所有客户端
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public async Task BroadcastMessage(string message)
    {
        await Clients.All.SendAsync("ReceiveBroadcast", message);
    }

    /// <summary>
    /// 向指定用户发送消息
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public async Task SendToUser(string userId, string message)
    {
        await Clients.Group(userId).SendAsync("ReceiveMessage", message);
    }

    /// <summary>
    /// 客户端连接时触发
    /// </summary>
    /// <returns></returns>
    public override async Task OnConnectedAsync()
    {
        Console.WriteLine("客户端已连接");
        var userId = Context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (!string.IsNullOrEmpty(userId)) { await Groups.AddToGroupAsync(Context.ConnectionId, userId); }
        await base.OnConnectedAsync();
    }

    /// <summary>
    /// 客户端断开连接时触发
    /// </summary>
    /// <param name="exception"></param>
    /// <returns></returns>
    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        Console.WriteLine("客户端已断开");
        var userId = Context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (!string.IsNullOrEmpty(userId)) { await Groups.RemoveFromGroupAsync(Context.ConnectionId, userId); }
        await base.OnDisconnectedAsync(exception);
    }
}
