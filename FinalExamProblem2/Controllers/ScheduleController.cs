//Margaret Medellin

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalExamProblem2.Models;

namespace FinalExamProblem2.Controllers
{
    public class ScheduleController : Controller
    {
       private DB_128040_practiceEntities db = new DB_128040_practiceEntities();
        
        // GET: Schedule
        public ActionResult Index(int? year)
        {
            if (year == null)
            {
                year = DateTime.Now.Year;
                //makes all years to the current year(2019)
            }
            var games = db.FootballSchedules.Where(s => s.Season == year);
            //var g = new List<FootballSchedule>();
            //foreach (var item in db.FootballSchedules)
            //{
            //    if (item.Season == year.Value)
            //    {
            //        g.Add(item);
            //    }
            //}
            return View(games);
        }
    }
}