using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MrFixIt.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MrFixIt.Controllers
{
    public class WorkersController : Controller
    {
        private MrFixItContext db = new MrFixItContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            var thisWorker = db.Workers.Include(i =>i.Jobs).FirstOrDefault(i => i.UserName == User.Identity.Name);
            if (thisWorker != null)
            {
                return View(thisWorker);
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult PendingJob(int jobId)
        {
            Debug.WriteLine("job id " + jobId);
            var selectedJob = db.Jobs.FirstOrDefault(j => j.JobId == jobId);
            Debug.WriteLine("selectedJob " + selectedJob.Description);
            selectedJob.Pending = true;
            db.SaveChanges();
            return Json(selectedJob);
        }
        public IActionResult CompletedJob(int jobId)
        {
            Debug.WriteLine("job id " + jobId);
            var selectedJob = db.Jobs.FirstOrDefault(j => j.JobId == jobId);
            Debug.WriteLine("selectedJob " + selectedJob.Description);
            selectedJob.Pending = true;
            db.SaveChanges();
            return Json(db.Workers.Include(i => i.Jobs).FirstOrDefault(i => i.UserName == User.Identity.Name));
        }

        [HttpPost]
        public IActionResult Create(Worker worker)
        {
            worker.UserName = User.Identity.Name;
            db.Workers.Add(worker); 
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
