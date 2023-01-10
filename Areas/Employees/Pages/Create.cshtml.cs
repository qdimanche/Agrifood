using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Agrifood.Models;
using Agrifood.Data;
using NuGet.Protocol.Plugins;

namespace Agrifood.Areas.Employees.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext ctx;

        public CreateModel(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        } 

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; } = new();
        

        public async Task<IActionResult> OnPostAsync()
        {
            var emptyEmployee = new Employee();

            if (await TryUpdateModelAsync(emptyEmployee, "Employee", f => f.FirstName, f => f.LastName, f => f.LandlinePhone, f => f.MobilePhone, f => f.Email))
            {
                ctx.Employees.Add(emptyEmployee);
                await ctx.SaveChangesAsync();

                return RedirectToPage("./Index");
            }

            return Page();



        }
    }
}
