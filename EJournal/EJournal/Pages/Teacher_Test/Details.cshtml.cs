using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EJournal.Data;
using EJournal.Models;

namespace EJournal.Pages.Teacher_Test
{
    public class DetailsModel : PageModel
    {
        private readonly EJournal.Data.ApplicationDbContext _context;

        public DetailsModel(EJournal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Journal Journal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Journal = await _context.Journal.FirstOrDefaultAsync(m => m.ID == id);

            if (Journal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
