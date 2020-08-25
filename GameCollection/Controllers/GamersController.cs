using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using GameCollection.Models;
using GameCollection.ViewModels;

namespace GameCollection.Controllers
{
    public class Gamers : Controller
    {
        // Starter Mock Data
        public List<Gamer> gamerList = new List<Gamer>(){new Gamer(1, "Legendary", "Lea"), new Gamer(2, "Kacey", "Tron"),  new Gamer(3, "Jessica", "Blevins")};
        // Sanity Endpoint
        public IActionResult Index()
        {
            return View();
        }
        // GET/READ endpoint to find gamer by ID
        public IActionResult GamerInfo(int gamerID)
        {
            // find gamer by ID using LINQ method
            Gamer matchingGamer = gamerList.FirstOrDefault(gamer => gamer.gamerID == gamerID);
            // if gamer is found
            if(matchingGamer != null)
            {
                // pass found gamer info as view data to default view
                ViewData["gamerID"] = matchingGamer.gamerID;
                ViewData["gamerFName"] = matchingGamer.gamerFName;
                ViewData["gamerLName"] = matchingGamer.gamerLName;
                return View(); 
            } 
            // if gamer is not found
            else 
            {
                // pass incorrect gamer ID to error view
                ViewData["gamerID"] = gamerID;
                return View("GamerNotFound");
            }
        }

        // GET/READ method to find gamer by ID and associated games
        public IActionResult GameCollection(int gamerID)
        {        
            // find gamer by ID using LINQ method
            Gamer matchingGamer = gamerList.FirstOrDefault(gamer => gamer.gamerID == gamerID);
            // if gamer is found
            if(matchingGamer != null)
            {
                // create new GamerDetailModel object
            GamerGameCollection GamerDetailsModel = new GamerGameCollection();

            // set gamer property of GamerDetailModel object
            GamerDetailsModel.Gamer = matchingGamer;
            // set list of video games property of GamerDetailModel object
            GamerDetailsModel.VideoGames = new List<VideoGame>()
            {
                new VideoGame(1, "Legend of Zelda : Breath of the Wild", "Adventure", "Switch"),
                new VideoGame(2, "Animal Crossing", "Casual", "Switch"),
                new VideoGame(3, "Mario Cart 8 Deluxe", "Completion", "Switch")
            };
                // send object to default view
                return View(GamerDetailsModel); 
            } 
            // if gamer is not found
            else 
            {
                // pass incorrect gamer ID to error view
                ViewData["gamerID"] = gamerID;
                return View("GamerNotFound");
            }
        }
    }
}