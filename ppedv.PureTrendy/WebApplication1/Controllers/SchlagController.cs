using ppedv.PureTrendy.Data.XML;
using ppedv.PureTrendy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SchlagController : Controller
    {
        EfContext context = new EfContext();
        // GET: Schlag
        public ActionResult Index()
        {
            //return View(context.Schlaginstrument.ToList());
            return View(new XmlManager().Load<Schlaginstrument>());
        }

        // GET: Schlag/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Schlag/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Schlag/Create
        [HttpPost]
        public ActionResult Create(Schlaginstrument si)
        {
            try
            {
                // TODO: Add insert logic here
                context.Schlaginstrument.Add(si);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Schlag/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Schlag/Edit/5
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

        // GET: Schlag/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Schlag/Delete/5
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
    }
}
