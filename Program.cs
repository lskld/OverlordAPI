using Microsoft.EntityFrameworkCore;
using OverlordAPI.Data;
using OverlordAPI.Interfaces;
using OverlordAPI.Repositories;
using System;

namespace OverlordAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddDbContext<OverlordDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DB_CONNECTION_STRING")));

            builder.Services.AddScoped<IMinionRepository, MinionRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
