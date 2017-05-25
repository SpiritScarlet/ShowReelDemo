using ShowReel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowReel.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        [HttpGet]
        public ActionResult News(string news, string text)
        {
            if (news == "newest")
            {

                var model =
                    from n in _news
                    orderby n.Date
                    select n;
                return View(model);
            }
            else if (text != null)
            {

                var model =
                    from n in _news
                    .OrderBy(n => n.Name)
                    .Where(n => text == null || n.Name.Contains(text))
                    select n;
                return View(model);
            }
            else {
                var model =
                from n in _news
                select n;
                return View(model);

            }

        }

        // GET: News/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: News/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: News/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: News/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<News> _news = new List<News>
        {

            new News {

                Id = 1,
                Date = "01/01/2017",
                Name = "Stranger Things’ creators reveal how many seasons the show will last",
                Description = "The creators of Stranger Things have discussed how many seasons they are planning for the hit show. The Netflix series will return on Halloween (October 31). A teaser trailer was released during the Super Bowl, while new stills have also been released. Speaking to Entertainment Weekly, the Duffer Brothers said that can see the show lasting four or five seasons – but things could change. “Everything changes as we move forward so we’ll see,” said Ross Duffer. " +
                "Matt Duffer added...",
                Image = "stranger_things.jpg",
                Link = "http://www.nme.com/news/tv/stranger-things-how-many-seasons-1974644#eChEufF9otRPGEct.99"

            },

            new News {

                Id = 2,
                Date = "02/01/2017",
                Name = "The Vampire Diaries Cast Say Goodbye to Mystic Falls for the Final Time",
                Description = "That's a wrap on The Vampire Diaries. After eight years of mysticism, heartbreak, frustrating romantic developments, and gravity-defying Hero Hair, the celebrated CW drama wrapped production on its very last episode Wednesday night (February 9). The cast and crew were...",
                Image = "vampire diaries.png",
                Link = "http://www.sidereel.com/posts/465423-news-the-vampire-diaries-cast-say-goodbye-to-mystic-falls-for-the-final-time-mtv-com"
            },

            new News {

                Id = 3,
                Date = "01/01/2017",
                Name = "'The Walking Dead' 7.10 Sneak Peeks: Rick Seeks Help From New Community",
                Description = "Can Rick turn their captors into their new allies in the upcoming episode titled 'New Best Friends'?",
                Image = "walking_dead.jpg",
                Link = "http://www.aceshowbiz.com/news/view/00105751.html"
            },

            new News {

                Id = 4,
                Date = "02/01/2017",
                Name = "Logan Composer Is Getting His Butt Sued Over Allegedly StolenLucifer Theme Song",
                Description = "Warner Bros. has a hell of a problem on its hands. A pair of musicians are suing the company and Logan composer Marco E. Beltrami for using the theme song they helped create for the show without giving them money or credit.",
                Image = "lucifer.jpg",
                Link = "http://feeds.gawker.com/~r/io9/full/~3/Ww7z5izNkNw/logan-composer-is-getting-his-butt-sued-over-allegedly-1792270597"
            },

            new News {

                Id = 5,
                Date = "03/01/2017",
                Name = "Sophie Turner hints at Sansa’s fate in Game of Thrones season 7",
                Description = "Sophie Turner attended the British Academy Film Awards (the BAFTAs) this past weekend, and dropped an important nugget of information about Sansa Stark’s future while on the red carpet. " + 
                "'We’re about to start shooting the next X-Men, we just finished shooting season 7 of Thrones, and I’ve got a couple of movies to do before X-Men starts, and then we go on to season 8! So I’ve got a busy year lined up...",
                Image = "sansa.jpg",
                Link = "http://winteriscoming.net/2017/02/13/sophie-turner-sansa-stark-game-of-thrones-season-7/"
            },

            new News {

                Id = 6,
                Date = "04/01/2017",
                Name = "Supernatural Goes Through the Motions of Manly Angst",
                Description = "Let's call Supernatural's 'Regarding Dean' 'pleasantly mediocre.' The episode hit all the right beats with the latest foray into not-the-plot-of-this-season. Dean (Jensen Ackles) got whammied by a witch. The spell in question slowly sapped his memories, leading to some easy LOLs and then the...",
                Image = "dean.jpg",
                Link = "http://www.tvguide.com/news/supernatural-regarding-dean-memory/?rss=breakingnews"
            }

        };
    }
}
