using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;
using Yuri.ArmsMall;
using Yuri.ArmsMall.Commons;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseAutofac();
await builder.AddApplicationAsync<ArmsMallApiModule>();
builder.Services.AddAspVersioning();
builder.Services.AddOpenApi("v1", option =>
{
    option.AddDocumentTransformer((document, context, cancellationToken) =>
    {
        document.Info = new() { Title = $"���������̳� - V1", Version = "v1", Description = $"���������̳���ؽӿ�" };
        document.Info.Contact = new OpenApiContact { Name = "ShenHao", Email = "shenhao@by56.com" };
        return Task.CompletedTask;
    });
});
builder.Services.AddOpenApi("v2", option =>
{
    option.AddDocumentTransformer((document, context, cancellationToken) =>
    {
        document.Info = new() { Title = $"���������̳� - V2", Version = "v2", Description = $"���������̳���ؽӿ�" };
        document.Info.Contact = new OpenApiContact { Name = "ShenHao", Email = "shenhao@by56.com" };
        return Task.CompletedTask;
    });
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}
await app.InitializeApplicationAsync();
app.MapControllers();
app.Run();
