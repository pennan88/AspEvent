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
        private readonly ASPuppgiftETT.Data.ASPuppgiftETTContext _context;

        public MyEventsModel(ASPuppgiftETT.Data.ASPuppgiftETTContext context)
        {
            _context = context;
        }

        public Attendee Attendee { get; set; }

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendee.Where(a => a.Id == 1).Include(e => e.Event).FirstOrDefaultAsync();
        }
    }
}
