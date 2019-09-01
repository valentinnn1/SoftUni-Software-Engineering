using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var allGames = db.Games.ToList();
                return this.View(allGames);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string name, string dlc, double price, string platform)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction("Index");
            }
            using (var db = new GameStoreDbContext())
            {
                Game game = new Game
                {
                    Name = name,
                    Dlc = dlc,
                    Price = price,
                    Platform = platform
                };
                db.Games.Add(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToEdit = db.Games.FirstOrDefault(x => x.Id == id);

                if (gameToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(gameToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToEdit = db.Games.FirstOrDefault(x => x.Id == game.Id);
                gameToEdit.Name = game.Name;
                gameToEdit.Dlc = game.Dlc;
                gameToEdit.Price = game.Price;
                gameToEdit.Platform = game.Platform;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToDelete = db.Games.FirstOrDefault(x => x.Id == id);
                if (gameToDelete == null)
                {
                    RedirectToAction("Index");
                }
                return this.View(gameToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Remove(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}