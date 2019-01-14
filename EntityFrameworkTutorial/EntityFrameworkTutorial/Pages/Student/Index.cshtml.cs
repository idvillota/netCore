using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkTutorial.Models;

namespace EntityFrameworkTutorial.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly EntityFrameworkTutorial.Models.SchoolContext _context;

        public IndexModel(EntityFrameworkTutorial.Models.SchoolContext context)
        {
            _context = context;
        }

        public IList<EntityFrameworkTutorial.Models.Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
