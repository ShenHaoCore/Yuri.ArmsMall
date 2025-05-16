using Scalar.AspNetCore;
using Yuri.ArmsMall;
using Yuri.ArmsMall.Common;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseAutofac();
await builder.AddApplicationAsync<ArmsMallApiModule>();
builder.Services.AddAspVersioning();
//builder.Services.AddTransient<IConfigureOptions<OpenApiOptions>, ConfigureOpenApiOptions>();
//builder.Services.AddOpenApi();
//builder.Services.AddOpenApi("v1", option => { option.AddDocumentTransformer((document, context, cancellationToken) => { return Task.CompletedTask; }); });
builder.Services.AddOpenApi("v1", option => { option.AddDocumentTransformer<ApiDocumentTransformer>(); });
builder.Services.AddOpenApi("v2", option => { option.AddDocumentTransformer<ApiDocumentTransformer>(); });

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}
await app.InitializeApplicationAsync();
app.MapControllers();
app.Run();
