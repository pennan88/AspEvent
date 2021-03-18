using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPuppgiftETT.Data;
using ASPuppgiftETT.Models;

namespace ASPuppgiftETT.Pages.Options
{
    public class CreateEventModel : PageModel
    {
        private readonly ASPuppgiftETT.Data.ASPuppgiftETTContext _context;

        public CreateEventModel(ASPuppgiftETT.Data.ASPuppgiftETTContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Event Event { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Event.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("../EventPage");
        }
    }
}
