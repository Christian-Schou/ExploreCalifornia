using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.ViewComponents
{
    [ViewComponent]
    public class DidYouKnowViewComponent : ViewComponent
    {
        private readonly DidYouKnowDataContext _didYouKnows;

        public DidYouKnowViewComponent(DidYouKnowDataContext didYouKnows)
        {
            _didYouKnows = didYouKnows;
        }

        public IViewComponentResult Invoke()
        {
            var didYouKnows = _didYouKnows.GetDidYouKnows();
            return View(didYouKnows);
        }
    }
}
