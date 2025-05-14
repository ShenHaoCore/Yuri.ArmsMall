using Scalar.AspNetCore;
using Yuri.ArmsMall;
using Yuri.ArmsMall.Scalars;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseAutofac();
await builder.AddApplicationAsync<ArmsMallApiModule>();
builder.Services.AddOpenApi(options => {
    options.AddDocumentTransformer<AuthenApiDocumentTransformer>();
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
