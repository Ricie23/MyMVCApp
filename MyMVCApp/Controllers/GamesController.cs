using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.Models;

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
        public ActionResult AddNewGame(string gameName, string gameGenre, int gamePrice)
        {
            GameModel e = new GameModel()
            {
               
                Name = gameName,
                Genre = gameGenre,
                Price = gamePrice
            };
            return View("ConfirmGame", e);
        }
        public ActionResult AddNewGame()
        {
            return View("NewGameForm");
        }
        public ActionResult TradeInPriceCalc()
        {
            return View("TradeInPriceCalc");
        }
    }
}