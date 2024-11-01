using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ciont_Patricia_Lab4.Data;
using Ciont_Patricia_Lab4.Models;

namespace Ciont_Patricia_Lab4.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Ciont_Patricia_Lab4.Data.Ciont_Patricia_Lab4Context _context;

        public CreateModel(Ciont_Patricia_Lab4.Data.Ciont_Patricia_Lab4Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
