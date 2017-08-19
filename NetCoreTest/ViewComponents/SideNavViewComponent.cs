using Microsoft.AspNetCore.Mvc;
using NetCoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTest.ViewComponents
{
    public class SideNav : ViewComponent
    {
        //This is where wew would get nav items from the DB for now we just pretend
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var SideNavItems = new List<MenuItemViewModel>();
            //mimic running task ie: getting data from DB
            await Task.Run(() =>
            {
                SideNavItems.Add(new MenuItemViewModel("Home", "Home"));
                SideNavItems.Add(new MenuItemViewModel("Email", "#"));
                SideNavItems.Add(new MenuItemViewModel("Something", "#"));
                SideNavItems.Add(new MenuItemViewModel("Something Else", "#"));
            });
            var viewModel = new MenuViewModel(SideNavItems);
            return View(viewModel);
        }

    }
}
