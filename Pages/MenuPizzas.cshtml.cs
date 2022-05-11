using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizzas_mama.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizzas_mama.Pages
{
    public class MenuPizzasModel : PageModel
    {
        private readonly pizzas_mama.Data.DataContext _context;

        public MenuPizzasModel(pizzas_mama.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
            Pizza = Pizza.OrderBy(p => p.prix).ToList();
        }
    }
}
