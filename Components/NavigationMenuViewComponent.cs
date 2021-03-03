using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5_McKennaTrussel_BookStore.Models;

namespace Assignment5_McKennaTrussel_BookStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookStoreRepository repository;

        public NavigationMenuViewComponent (IBookStoreRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCat = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
