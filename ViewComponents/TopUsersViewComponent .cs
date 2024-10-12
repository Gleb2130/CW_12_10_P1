using Microsoft.AspNetCore.Mvc;
using CW_12_10_P1.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace YourNamespace.ViewComponents
{
    public class TopUsersViewComponent : ViewComponent
    {
        private static List<User> userScores = new List<User>
        {
            new User { Username = "User1", Score = 150 },
            new User { Username = "User2", Score = 200 },
            new User { Username = "User3", Score = 300 },
            new User { Username = "User4", Score = 250 },
            new User { Username = "User5", Score = 350 },
            new User { Username = "User6", Score = 100 },
            new User { Username = "User7", Score = 400 },
            new User { Username = "User8", Score = 450 },
            new User { Username = "User9", Score = 600 },
            new User { Username = "User10", Score = 500 }
        };

        public IViewComponentResult Invoke()
        {
            var topUsers = userScores.OrderByDescending(u => u.Score).Take(10);
            return View(topUsers);
        }
    }
}