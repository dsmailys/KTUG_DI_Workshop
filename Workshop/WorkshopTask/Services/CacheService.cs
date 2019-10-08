using System.Collections.Generic;
using System.Linq;
using WorkshopTask.Models;

namespace WorkshopTask.Services
{
    public class CacheService
    {
        private readonly List<TaskModel> tasks = new List<TaskModel> ();
        public void AddToCache (TaskModel task) {
            var logger = new LoggerService ();
            logger.Log ("Adding to cache");

            tasks.Add (task);
        }

        public bool Contains (int id) {
            var logger = new LoggerService ();

            logger.Log ("Checking if cache contains task model");
            var foundTask = tasks.FirstOrDefault (t => t.Id == id);

            if (foundTask is null) {
                logger.Log ("task was not found");
                return false;
            }

            logger.Log ("Task was found.");
            return true;
        }

        public TaskModel Get (int id) {
            var logger = new LoggerService ();
            logger.Log ("Getting task from cache");
            var foundTask = tasks.FirstOrDefault (t => t.Id == id);
            return foundTask;
        }

        public List<TaskModel> GetAll () {
            return tasks;
        }
    }
}