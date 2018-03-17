using GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{
    public class HomeController : Controller
    {
        private static GameBoardViewModel gb;
        private static GameEngine gameEngine = new GameEngine();

        public HomeController() { gb = new GameBoardViewModel(); }

        public ActionResult Index()
        {
            gb.squares = gameEngine.squares;
            gb.player = gameEngine.GetPlayer(HttpContext.Session.SessionID);
            if(gb.player == -1)
            {
                return View("GameFull");
            }
            gb.currentPlayer = gameEngine.currentPlayer;
            return View(gb);
        }

        public ActionResult LeaveGame(int id)
        {
            gameEngine.PlayerLeave(id);
            return View("GameLeft");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Reset()
        {
            gameEngine = new GameEngine();
            return RedirectToAction("Index");
        }

        public ActionResult MakeMove(string id, int player)
        {
            gameEngine.MakeMove(player, int.Parse(id));
            int playerWon = gameEngine.HasWon();
            if(playerWon > 0)
            {
                 return View("Winner", playerWon);
            }
            else 
                return RedirectToAction("Index");
        }
    }
}