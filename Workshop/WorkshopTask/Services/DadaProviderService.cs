using System.Collections.Generic;
using System.Linq;
using WorkshopTask.Models;

namespace WorkshopTask.Services
{
    public class DataProviderService
    {
        private readonly List<TaskModel> tasks = new List<TaskModel> ();
        private readonly CacheService cache = new CacheService ();

        public IEnumerable<TaskModel> GetAllTaskData()
        {
            var cachedData = cache.GetAll ();
            if (cachedData is null || cachedData.Count == 0) {
                cachedData = new DataRepository ().QuerryTasks ();
            }

            foreach (var data in cachedData) {
                cache.AddToCache (data);
                tasks.Add (data);
            }

            var logger = new LoggerService ();
            logger.Log ("Returning all task data");

            return tasks;
        }

        public TaskModel GetTaskData (int id) {
            var logger = new LoggerService ();

            if (cache.Contains (id)) {
                logger.Log ("returning from cache");
                return cache.Get (id);
            }

            var data = new DataRepository ().QuerryTasks ();
            
            var task = data.FirstOrDefault (t => t.Id == id);

            if (task is null) {
                logger.Log ("task was not found.");
                return null;
            }

            cache.AddToCache (task);
            logger.Log ($"returning task with id == {id}");
            return task;
        }
    }
}