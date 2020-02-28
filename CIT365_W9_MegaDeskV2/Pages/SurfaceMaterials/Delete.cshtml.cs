﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIT365_W9_MegaDeskV2.Models;
using CIT365_W9_MegaDeskV2.Data;

namespace CIT365_W9_MegaDeskV2.Pages.SurfaceMaterials
{
    public class DeleteModel : PageModel
    {
        private readonly CIT365_W9_MegaDeskV2.Data.CIT365_W9_MegaDeskV2Context _context;

        public DeleteModel(CIT365_W9_MegaDeskV2.Data.CIT365_W9_MegaDeskV2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public SurfaceMaterial SurfaceMaterial { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SurfaceMaterial = await _context.SurfaceMaterial.FirstOrDefaultAsync(m => m.id == id);

            if (SurfaceMaterial == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SurfaceMaterial = await _context.SurfaceMaterial.FindAsync(id);

            if (SurfaceMaterial != null)
            {
                _context.SurfaceMaterial.Remove(SurfaceMaterial);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}