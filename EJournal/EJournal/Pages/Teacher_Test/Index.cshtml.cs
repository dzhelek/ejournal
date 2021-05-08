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
    public class IndexModel : PageModel
    {
        private readonly EJournal.Data.ApplicationDbContext _context;

        public IndexModel(EJournal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Journal> Journal { get;set; }

        public async Task OnGetAsync()
        {
            Journal = await _context.Journal.ToListAsync();
        }
    }
}
