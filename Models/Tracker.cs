using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowReel.Models
{
    public class Tracker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Seasons { get; set; }
        public Array EpisodesPerSeason { get; set; }
    }
}