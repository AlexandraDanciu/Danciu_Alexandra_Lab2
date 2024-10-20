﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Danciu_Alexandra_Lab2.Data;
using Danciu_Alexandra_Lab2.Models;

namespace Danciu_Alexandra_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Danciu_Alexandra_Lab2.Data.Danciu_Alexandra_Lab2Context _context;

        public DetailsModel(Danciu_Alexandra_Lab2.Data.Danciu_Alexandra_Lab2Context context)
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
