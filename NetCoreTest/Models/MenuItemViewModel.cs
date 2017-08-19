using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTest.Models
{
    public class MenuItemViewModel
    {
        public string Title { get; }
        public string Text { get; }
        public string Action { get; }
        public string Controller { get; }
        public string IconClass { get; }
        public List<MenuItemViewModel> SubNavItems { get; }

        public MenuItemViewModel(string text, string title = "", string iconClass = "", string action = "", string controller = "",  List<MenuItemViewModel> subNavItems = null)
        {
            Text = text;
            Title = title ?? text;
            Action = action;
            Controller = controller;
            SubNavItems = subNavItems;
            IconClass = iconClass;
        }
    }
}
