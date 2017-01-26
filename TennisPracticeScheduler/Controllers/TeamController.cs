using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TennisPracticeScheduler.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult GetPlayers(String name)
        {
            TennisSchedulerDBDataContext DBcontext = new TennisSchedulerDBDataContext();
            var player = DBcontext.Players.Where(a => a.FirstName.Contains(name));
            return Json(player, JsonRequestBehavior.AllowGet);
        }
    }
}