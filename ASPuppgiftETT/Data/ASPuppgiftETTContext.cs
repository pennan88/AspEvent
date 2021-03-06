using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPuppgiftETT.Models;

namespace ASPuppgiftETT.Data
{
    public class ASPuppgiftETTContext : DbContext
    {
        public ASPuppgiftETTContext(DbContextOptions<ASPuppgiftETTContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Event { get; set; }

        public DbSet<Attendee> Attendee { get; set; }

        public DbSet<Organizer> Organizer { get; set; }

        public void Seed()
        {

            Database.EnsureCreated();
            if ( Event.Any() ||
                this.Attendee.Any() ||
                this.Organizer.Any() )
            {
                return;
            }

            var Attendee = new Attendee[]
            {
                    new Attendee{Name = "Alex", Email = "mail@mail.com", Phone_number = "076654733"},
            };

            var Organizer = new Organizer[]
            {
                new Organizer{Name = "SummerOrganizer", Email = "Summerburste@mail.com", Phone_number = "0755346788"},
                new Organizer{Name = "SuperOrganizer", Email = "Super@mail.com", Phone_number = "0755346788"},
                new Organizer{Name = "TrashMan", Email = "Trash@mail.com", Phone_number = "0755346788"},

            };

            var Events = new Event[]
            {
                 new Event{Title="Summerburst", Adress="Göteborg", Tickets_left="100", Description="Party", Location="Ullevi",Date = DateTime.Now, Organizer = Organizer[0]},
                 new Event{Title="Super Festival 2021", Adress="Stockholm", Tickets_left="100", Description="Biggest Party ever", Location="Globen",Date = DateTime.Now, Organizer = Organizer[1]},
                 new Event{Title="TrashFest21", Adress="TrashLand", Tickets_left="100", Description="Trash Party", Location="Trash Street",Date = DateTime.Now, Organizer = Organizer[2]}
            };

            this.Attendee.AddRange(Attendee);
            this.Organizer.AddRange(Organizer);
            Event.AddRange(Events);
            SaveChanges();
        }
    }


}
