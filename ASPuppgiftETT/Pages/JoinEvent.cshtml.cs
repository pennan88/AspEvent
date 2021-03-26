﻿using System;
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
    public class JoinEventModel : PageModel
    {
        private readonly ASPuppgiftETTContext _context;

        public JoinEventModel(ASPuppgiftETTContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if ( id == null )
            {
                return NotFound();
            }

            Event = await _context.Event.Include(o => o.Organizer).FirstOrDefaultAsync(m => m.Id == id);

            if ( Event == null )
            {
                return NotFound();
            }
            return Page();
        }

        [BindProperty]
        public Event MyEvent { get; set; }

        public async Task<IActionResult> OnPostAsync(int? id)
        {

            var attendee = await _context.Attendee.Where(a => a.Id == 1).Include(e => e.Event).FirstOrDefaultAsync();

            var join = await _context.Event.Where(e => e.Id == id).FirstOrDefaultAsync();

            attendee.Event.Add(join);
            await _context.SaveChangesAsync();
            return RedirectToPage("/MyEvents");

        }
    }
}
