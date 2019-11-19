using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Public instance of the Menu class
        /// </summary>
        public Menu Menu { get; } = new Menu();
        

        public void OnGet()
        {
            
        }
    }
}