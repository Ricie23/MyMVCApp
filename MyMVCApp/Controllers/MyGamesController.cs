using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.DAL;
using MyMVCApp.Models;

namespace MyMVCApp.Controllers
{
    public class MyGamesController : Controller
    {
        private GameContext db = new GameContext();

        // GET: MyGames
        public ActionResult Index()
        {
            return View(db.Games.ToList());
        }

        // GET: MyGames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyGames myGames = db.Games.Find(id);
            if (myGames == null)
            {
                return HttpNotFound();
            }
            return View(myGames);
        }

        // GET: MyGames/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyGames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Genre,Price")] MyGames myGames)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(myGames);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myGames);
        }

        // GET: MyGames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyGames myGames = db.Games.Find(id);
            if (myGames == null)
            {
                return HttpNotFound();
            }
            return View(myGames);
        }

        // POST: MyGames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Genre,Price")] MyGames myGames)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myGames).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myGames);
        }

        // GET: MyGames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyGames myGames = db.Games.Find(id);
            if (myGames == null)
            {
                return HttpNotFound();
            }
            return View(myGames);
        }

        // POST: MyGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyGames myGames = db.Games.Find(id);
            db.Games.Remove(myGames);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
