using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciont_Patricia_Lab4.Data;
using Ciont_Patricia_Lab4.Models;

namespace Ciont_Patricia_Lab4.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Ciont_Patricia_Lab4.Data.Ciont_Patricia_Lab4Context _context;

        public DetailsModel(Ciont_Patricia_Lab4.Data.Ciont_Patricia_Lab4Context context)
        {
            _context = context;
        }

        public Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else
            {
                Author = author;
            }
            return Page();
        }
    }
}
