using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPuppgiftETT.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public string Tickets_left { get; set; }
        public Organizer Organizer { get; set; }
        public List<Attendee> Attendees { get; set; }
    }
}
