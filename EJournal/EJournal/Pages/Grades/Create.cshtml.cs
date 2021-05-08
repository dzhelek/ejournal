using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EJournal.Data;
using EJournal.Models;

namespace EJournal.Pages.Grades
{
    public class CreateModel : PageModel
    {
        private readonly EJournal.Data.ApplicationDbContext _context;

        public CreateModel(EJournal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Journal Journal { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Journal.Add(Journal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
