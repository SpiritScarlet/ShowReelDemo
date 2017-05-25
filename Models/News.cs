using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowReel.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }

    }
}