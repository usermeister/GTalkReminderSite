using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GTalkReminderSite.Models;


namespace GTalkReminderSite.Controllers
{
    public class TaskController : Controller
    {
        ReminderDBEntities db = new ReminderDBEntities();
        //
        // GET: /Task/

        public ActionResult Index()
        {
            return View(db.Tasks.ToList());
        }

        //
        // GET: /Task/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Task/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Task/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Task newTask = new Task();

                newTask.title = collection["title"];
                newTask.message = collection["message"];
                newTask.startTime = DateTime.Parse(collection["startTime"]);
                newTask.endTime = DateTime.Parse(collection["endTime"]);
                newTask.interval = collection["interval"];
                newTask.recipients = collection["recipients"];

                db.AddToTasks(newTask);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Task/Edit/5
 
        public ActionResult Edit(int id)
        {
            var tsk = (from t in db.Tasks
                       where t.taskID == id
                       select t).First();

            return View(tsk);
        }

        //
        // POST: /Task/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var tsk = (from t in db.Tasks
                           where t.taskID == id
                           select t).First();

                tsk.title = collection["title"];
                tsk.message = collection["message"];
                tsk.startTime = DateTime.Parse(collection["startTime"]);
                tsk.endTime = DateTime.Parse(collection["endTime"]);
                tsk.interval = collection["interval"];
                tsk.recipients = collection["recipients"];

                if (!ModelState.IsValid)
                    return View(tsk);

                //db.ApplyPropertyChanges(tsk.EntityKey.EntitySetName, tsk);
                db.ApplyCurrentValues(tsk.EntityKey.EntitySetName, tsk);
                db.SaveChanges(); 

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Task/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Task/Delete/5

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
    }
}
