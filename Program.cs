using Microsoft.EntityFrameworkCore;
using OverlordAPI.Data;
using OverlordAPI.Interfaces;
using OverlordAPI.Repositories;
using OverlordAPI.Services;
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

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<OverlordDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DB_CONNECTION_STRING")));

            builder.Services.AddScoped<IMinionRepository, MinionRepository>();
            builder.Services.AddScoped<IMinionService, MinionService>();
            builder.Services.AddScoped<IMissionRepository, MissionRepository>();
            builder.Services.AddScoped<IMissionService, MissionService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
