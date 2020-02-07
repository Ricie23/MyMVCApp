using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{
    public class MyGames
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        public virtual ICollection<Stats> Stats { get; set; }
        public virtual ICollection<Trophies> Trophies { get; set; }
        public virtual ICollection<CoverArt> Covers { get; set; }


    }
}