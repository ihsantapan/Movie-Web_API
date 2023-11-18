using Microsoft.EntityFrameworkCore;
using Project.Repositories.Abstract;
using Project.Repositories.Concrete;
using Project.Repositories.Context;
using Project.Services.Abstract;
using Project.Services.Concrete;
using System;

namespace _02_WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultCon")));

            builder.Services.AddTransient<IOyuncuService, OyuncuManager>();
            builder.Services.AddTransient<IOyuncuRepository, OyuncuRepository>();

            builder.Services.AddTransient<IFilmService, FilmManager>();
            builder.Services.AddTransient<IFilmRepository, FilmRepository>();

            builder.Services.AddTransient<IKategoriService, KategoriManager>();
            builder.Services.AddTransient<IKategoriRepository, KategoriRepository>();

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