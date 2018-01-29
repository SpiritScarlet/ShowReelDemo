using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShowReel.Models
{
    public class ShowReelDB : DbContext
    {
        public ShowReelDB() : base("name=DefaultConnection"){}
        public DbSet<Tvshow> Tvshows { get; set; }
        public DbSet<EpisodeGuide> Episode { get; set; }
    }
}