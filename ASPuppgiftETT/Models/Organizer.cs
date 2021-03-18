using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPuppgiftETT.Models
{
    public class Organizer
    {
        public int OrganizerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public List<Event> Events { get; set; }
    }
}
