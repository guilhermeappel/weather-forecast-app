using Microsoft.OpenApi.Models;
using System.Reflection;
using Weather.Forecast.API.Configurations;

const string DEFAULT_CORS_POLICY = "DefaultCorsPolicy";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        DEFAULT_CORS_POLICY,
        builder =>
        {
            builder.WithOrigins("http://localhost:3000")
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Weather Forecast API", Version = "v1" });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

builder.Services.AddHttpClientConfiguration(builder.Configuration);
builder.Services.AddGatewaysConfiguration();
builder.Services.AddServicesConfiguration();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(DEFAULT_CORS_POLICY);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
