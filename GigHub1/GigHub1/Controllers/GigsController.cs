using GigHub1.Models;
using GigHub1.ViewModel;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigHub1.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _dbContext;
        public GigsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Gigs
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _dbContext.Genres
            };
        

            

            return View(viewModel);
        }
    }
}