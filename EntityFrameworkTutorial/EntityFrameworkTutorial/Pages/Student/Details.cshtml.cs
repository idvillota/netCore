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
    public class DetailsModel : PageModel
    {
        private readonly EntityFrameworkTutorial.Models.SchoolContext _context;

        public DetailsModel(EntityFrameworkTutorial.Models.SchoolContext context)
        {
            _context = context;
        }

        public EntityFrameworkTutorial.Models.Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
