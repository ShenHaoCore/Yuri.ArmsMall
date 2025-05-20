using Scalar.AspNetCore;
using Yuri.ArmsMall;
using Yuri.ArmsMall.Commons;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseAutofac();
await builder.AddApplicationAsync<ArmsMallApiModule>();
builder.Services.AddAspVersioning();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}
await app.InitializeApplicationAsync();
app.MapControllers();
app.Run();
