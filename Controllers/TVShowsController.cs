using ShowReel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace ShowReel.Controllers
{
    public class TVShowsController : Controller
    {
        // GET: TVShows
        ShowReelDB _db = new ShowReelDB();
        [HttpGet]
        public ActionResult TVshow(String action = null, String type = null, String keyword = null)
        {

            if (type == "popularity")
            {
                var model =
                    _db.Tvshows
                    .OrderByDescending(r => r.Rating)
                    .Where(r => keyword == null || r.Name.StartsWith(keyword));
                return View(model);
            }
            else if (type == "premiereYear" )
            {

                var model = 
                    _db.Tvshows
                    .OrderBy(r => r.Year)
                    .Where(r => keyword == null || r.Name.StartsWith(keyword));
                return View(model);
            }
            else {
                var model =
                _db.Tvshows
                .OrderByDescending(r=>r.Name)
                .Where(r=> keyword == null || r.Name.StartsWith(keyword));
                return View(model);
            }
            
             
            
        }

      

        // GET: TVShows/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TVShows/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TVShows/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TVShows/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TVShows/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TVShows/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TVShows/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      

        protected override void Dispose(bool disposing)
        {
            if (_db != null) {

                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
