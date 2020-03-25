﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StackoverflowDb.EFCore;
using System.Collections.Generic;
using System.Linq;

namespace EffectiveEFCore.Pages.Posts
{
    public class IndexModel : PageModel
    {
        readonly StackOverflowContext _context;

        public IndexModel(StackOverflowContext context)
        {
            _context = context;
        }

        public List<StackoverflowDb.EFCore.Data.Posts> Posts { get; set; }
        public async System.Threading.Tasks.Task OnGetAsync()
        {
            Posts = await _context.Posts.Take(20).ToListAsync();
        }
    }
}