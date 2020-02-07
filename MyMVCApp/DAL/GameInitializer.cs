using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyMVCApp.Models;

namespace MyMVCApp.DAL
{
    public class GameInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GameContext>
    {
        protected override void Seed(GameContext context)
        {
            var games = new List<MyGames>
            {
                new MyGames {ID=1, Name="Red Dead Redemption 2", Genre="Action/Adventure", Price=59.99},
                new MyGames {ID=2, Name="Far Cry 5", Genre="Action/Adventure", Price=39.99},
                new MyGames {ID=3, Name="Rocket League", Genre="Sports", Price=20.00},
                new MyGames {ID=4,Name="Overcooked", Genre="Puzzle", Price=14.99},
                new MyGames {ID=5,Name="Kingdom Hearts 3", Genre="RPG", Price=49.99},
                new MyGames {ID=6, Name="Spiderman", Genre="Action/Adventure", Price=29.99},
                new MyGames {ID=7, Name="Lego: The Hobbit", Genre="Puzzle, Action/Adventure", Price=9.99},
                new MyGames {ID=8,Name="Tony Hawk's Pro Skater 5", Genre="Sports", Price=9.99},
            };
            games.ForEach(g => context.Games.Add(g));
            context.SaveChanges();

            var gameStats = new List<Stats>
            {
                new Stats{ GameID=1, StatsID=1, HoursPlayed=130, IsBeaten= true, TrophiesEarned = 12 },
                new Stats{ GameID=2, StatsID=2, HoursPlayed=80, IsBeaten= true, TrophiesEarned = 22 },
                new Stats{ GameID=3, StatsID=3, HoursPlayed=30, IsBeaten= false, TrophiesEarned = 19 },
                new Stats{ GameID=4, StatsID=4, HoursPlayed=50, IsBeaten= false, TrophiesEarned = 10 },
                new Stats{ GameID=5, StatsID=5, HoursPlayed=42, IsBeaten= true, TrophiesEarned = 7 },
                new Stats{ GameID=6, StatsID=6, HoursPlayed=35, IsBeaten= true, TrophiesEarned = 30 },
                new Stats{ GameID=7, StatsID=7, HoursPlayed=6, IsBeaten= false, TrophiesEarned = 1 },
                new Stats{ GameID=8, StatsID=8, HoursPlayed=15, IsBeaten= false, TrophiesEarned = 4 }
            };
            gameStats.ForEach(s => context.Stats.Add(s));
            context.SaveChanges();

            var trophieList = new List<Trophies>
            {
                new Trophies{ TrophyID = 1, StatsID=1, Name="Redemption", Description="Finish the Final Chapter", Type="Gold"},
                new Trophies{ TrophyID = 2, StatsID=1, Name="Helping Hand", Description="Complete All Companion Missions", Type="Silver"},
                new Trophies{ TrophyID = 3, StatsID=3, Name="Distance Driver", Description="Drive 5000 Kilometers", Type="Bronze"},
                new Trophies{ TrophyID = 4, StatsID=3, Name="Hat Trick", Description="Score Three Goals in One Game", Type="Bronze"},
                new Trophies{ TrophyID = 5, StatsID=4, Name="Bon Apetit", Description="Get Three Stars On every Level in the First Chapter", Type="Silver"},
                new Trophies{ TrophyID = 6, StatsID=5, Name="You've Got a Friend", Description="Complete Toy Story World", Type="Bronze"},
                new Trophies{ TrophyID = 7, StatsID=6, Name="Wonderful Spider-Man", Description="Complete The Storyline In New Game Plus", Type="Platinum"},
                new Trophies{ TrophyID = 8, StatsID=6, Name="Spectacular Spider-Man", Description="Complete 100% Trophies", Type="Platinum"},
            };
            trophieList.ForEach(t => context.Trophies.Add(t));
            context.SaveChanges();
        }
    
    }

}