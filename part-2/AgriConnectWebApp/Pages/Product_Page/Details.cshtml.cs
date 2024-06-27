﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgriConnectWebApp.Data;
using AgriConnectWebApp.Models;

namespace AgriConnectWebApp.Pages.Product_Page
{
    public class DetailsModel : PageModel
    {
        private readonly AgriConnectWebApp.Data.ApplicationDbContext _context;

        public DetailsModel(AgriConnectWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products
                .Include(p => p.Farmer).FirstOrDefaultAsync(m => m.ProductId == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
