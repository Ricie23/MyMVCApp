using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyMVCApp.Models
{
    public class Trophies
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public int TrophyID { get; set; }
        public int StatsID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public virtual Stats Stats { get; set; }
        public virtual MyGames Games { get; set; }
    }
}