using MVCDemoC2025.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoC2025.Controllers
{
    public class PeopleController : Controller
    {
        List<PersonModel> people = new List<PersonModel>();
        // GET: People
        public ActionResult Index()
        {
            if (Session["people"] == null)
            {
                people.Add(new PersonModel
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Id = 1
                });
                Session["people"] = people;
            }
            else
            {
                people = (List<PersonModel>)Session["people"];
            }

            return View(people);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(PersonModel model)
        {
            try
            {
                // TODO: Add insert logic here
                //people.Add(model);
                //int edad = (int)Session["edad"];
                ((List<PersonModel>)Session["people"]).Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
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

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
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
