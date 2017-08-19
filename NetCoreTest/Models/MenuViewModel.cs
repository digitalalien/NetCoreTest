using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTest.Models
{
    public class MenuViewModel
    {
        public List<MenuItemViewModel> SideNavItems { get; }
        public string Title { get; }

        public MenuViewModel (List<MenuItemViewModel> sideNavItems, string title = "")
        {
            SideNavItems = sideNavItems;
            Title = title;
        }
    }
}
