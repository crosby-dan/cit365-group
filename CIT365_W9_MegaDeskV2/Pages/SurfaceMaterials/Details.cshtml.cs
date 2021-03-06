﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;

namespace MegaDesk.Pages.SurfaceMaterials
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskContext _context;

        public DetailsModel(MegaDeskContext context)
        {
            _context = context;
        }

        public SurfaceMaterial SurfaceMaterial { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SurfaceMaterial = await _context.SurfaceMaterial.FirstOrDefaultAsync(m => m.Id == id);

            if (SurfaceMaterial == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
