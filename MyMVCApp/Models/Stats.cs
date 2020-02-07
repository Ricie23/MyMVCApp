using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{
    public class Stats
    {
        public int StatsID { get; set; }
        public int GameID { get; set; }
        public int HoursPlayed { get; set; }
        public bool  IsBeaten { get; set; }
        public int TrophiesEarned { get; set; }
        public virtual MyGames Games { get; set; }
        public virtual Trophies Trophies { get; set; }

    }
}