using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPuppgiftETT
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<Data.ASPuppgiftETTContext>();


                context.RemoveRange(context.Event);

                var Events = new Models.Event[]
                {
                    new Models.Event{Title="Summerburst", Adress="Göteborg", Tickets_left="100", Description="Party", Location="Ullevi"},
                    new Models.Event{Title="Super Festival 2021", Adress="Stockholm", Tickets_left="100", Description="Biggest Party ever", Location="Globen"},
                    new Models.Event{Title="TrashFest21", Adress="TrashLand", Tickets_left="100", Description="Trash Party", Location="Trash Street"}
                };
                context.Event.AddRange(Events);
                context.SaveChanges();
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
