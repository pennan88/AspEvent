using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPuppgiftETT.Data;
using ASPuppgiftETT.Models;

namespace ASPuppgiftETT.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly ASPuppgiftETTContext _context;

        public MyEventsModel(ASPuppgiftETTContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }

        public async Task OnGetAsync()
        {

            Event = await _context.Event.Include(o => o.Organizer).ToListAsync();
        }
    }
}
