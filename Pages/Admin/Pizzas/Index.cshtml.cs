using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizzas_mama.Data;
using pizzas_mama.Models;

namespace pizzas_mama.Pages.Admin.Pizzas
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly pizzas_mama.Data.DataContext _context;

        public IndexModel(pizzas_mama.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
        }
    }
}
