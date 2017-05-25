using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowReel.Models
{
    public class TvShowModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public string Image { get; set; }
        public int Year { get; set; }
        
    }
}