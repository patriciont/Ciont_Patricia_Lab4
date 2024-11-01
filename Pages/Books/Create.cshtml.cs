using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ciont_Patricia_Lab4.Data;
using Ciont_Patricia_Lab4.Models;
using Nume_Pren_Lab2.Models;

namespace Ciont_Patricia_Lab4.Pages.Books
{
    public class CreateModel : BookCategoriesPageModel
    {
        private readonly Ciont_Patricia_Lab4.Data.Ciont_Patricia_Lab4Context _context;

        public CreateModel(Ciont_Patricia_Lab4.Data.Ciont_Patricia_Lab4Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
           "PublisherName");
            ViewData["Author"] = new SelectList(_context.Set<Author>(), "ID",
"FirstName", "LastName");
            var book = new Book();
            book.BookCategories = new List<BookCategory>();

            PopulateAssignedCategoryData(_context, book);
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
