using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowReel.Models
{
    public class UserShowView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Seasons { get; set; }
        public int Episodes { get; set; }

        public string Image { get; set; }
        public string Description { get; set; }
    }
}