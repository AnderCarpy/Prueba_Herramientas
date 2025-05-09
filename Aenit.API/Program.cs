using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace Aenit.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AppContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("AppDbContext.postgres") ?? throw new InvalidOperationException("Connection string 'AppContext' not found.")));

            // Add services to the container.

            builder.Services.AddDbContext<AppContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("AppContext.sqlServer")
     ?? throw new InvalidOperationException("Connection string 'AppdbContext.sqlServer' not found.")));


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
