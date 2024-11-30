using AlunosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace School_Mininal_Api.Extensions
{
    public static class BuilderExtensions
    {
        public static WebApplicationBuilder AddBuilder(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Context>(options =>
                                                   options.UseSqlite(builder.Configuration.GetConnectionString("conexaobancodados")));
            return builder;
        }

        public static WebApplicationBuilder AddService(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRepository, Repository>();
            return builder;
        }
    }
}
