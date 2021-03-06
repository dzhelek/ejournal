using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EJournal.Data;
using EJournal.Models;

namespace EJournal.Pages.Grades
{
    public class IndexModel : PageModel
    {
        private readonly EJournal.Data.ApplicationDbContext _context;

        public IndexModel(EJournal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Journal> Journal { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var grades = from m in _context.Journal
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                grades = grades.Where(s => s.SUBJECT.Contains(SearchString));
            }

            Journal = await grades.ToListAsync();
        }
    }
}
