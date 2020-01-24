using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApp.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Index()
        {
            return RedirectToAction("ShowallGames", "Games");
        }
        public ActionResult ShowAllGames()
        {
                  return View();
        }

        [HttpPost]
        public ActionResult AddNewGame(string name)
        {
            ViewBag.Message = "You added " + name + " to your games.";
            return View("ConfirmGame");
        }
        public ActionResult AddNewGame()
        {
            return View("NewGameForm");
        }

    }
}