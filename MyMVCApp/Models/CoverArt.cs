using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{
    public class CoverArt
    {
        public int ID { get; set; }
        public int MyGamesID { get; set; }
        public string PhotoPath { get; set; }
        public string AltText { get; set; }
        public virtual MyGames MyGames { get; set; }
    }
}