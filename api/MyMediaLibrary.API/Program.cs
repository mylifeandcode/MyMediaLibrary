using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MyMediaLibrary.Application.Security.Interfaces;
using MyMediaLibrary.Application.Security.Models;
using MyMediaLibrary.Application.Security.Services;
using MyMediaLibrary.Domain.Users;
using MyMediaLibrary.Infrastructure;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-7.0&tabs=visual-studio

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<MediaLibraryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//From https://andrewlock.net/exploring-the-dotnet-8-preview-introducing-the-identity-api-endpoints/
builder.Services
    .AddIdentityApiEndpoints<MediaLibraryUser>()
    .AddEntityFrameworkStores<MediaLibraryDbContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IAuthService, AuthService>();
builder.Services.AddSingleton<ITokenService, TokenService>();

//Add authentication and authorization
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
        //TODO: Implement
        Guid? userId = authService.GetUserId(credentials);
        if (userId.HasValue)
        {
            return Results.Ok(tokenService.GenerateJwtToken(userId.ToString(), credentials.UserName, "Standard"));
        }
        else 
        {
            return Results.Unauthorized();
        }
    });


app.Run();
