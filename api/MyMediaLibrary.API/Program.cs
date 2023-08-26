using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyMediaLibrary.Application.Security.Interfaces;
using MyMediaLibrary.Application.Security.Models;
using MyMediaLibrary.Application.Security.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-7.0&tabs=visual-studio

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IAuthService, AuthService>();
builder.Services.AddAuthentication().AddJwtBearer("Bearer", options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("the-library")) //TODO: Replace with config-driven value
    };
});

builder.Services.AddAuthorization();
var app = builder.Build();

//TODO: Add authentication and authorization

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

//app.MapControllers();

app.MapGet("/hello", () => { return "Hello world!"; });
app.MapPost(
    "/login",
    ([FromServices] IAuthService authService, [FromServices] ITokenService tokenService, [FromBody] UserCredentials credentials) =>
    {
        if (authService.IsValidUser(credentials))
        {
            return Results.Ok(tokenService.GenerateJwtToken("", "", ""));
        }
        else 
        {
            return Results.Unauthorized();
        }
    });


app.Run();
