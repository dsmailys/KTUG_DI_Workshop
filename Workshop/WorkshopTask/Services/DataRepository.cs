using System.Collections.Generic;
using WorkshopTask.Models;

namespace WorkshopTask.Services
{
    public class DataRepository
    {
        public List<TaskModel> QuerryTasks() => tasks;

        private readonly List<TaskModel> tasks = new List<TaskModel> {
                new TaskModel {
                    Id = 1,
                    Description = "First Task Model",
                    IsDone = false,
                    Name = "Task1",
                    ShortDescription = "First Task"
                },
                new TaskModel {
                    Id = 2,
                    Description = "Second Task Model",
                    IsDone = false,
                    Name = "Task2",
                    ShortDescription = "Second Task"
                },
                new TaskModel {
                    Id = 3,
                    Description = "Third Task Model",
                    IsDone = true,
                    Name = "Task3",
                    ShortDescription = "Third Task"
                },
                new TaskModel {
                    Id = 4,
                    Description = "Fourth Task Model",
                    IsDone = true,
                    Name = "Task4",
                    ShortDescription = "Fourth Task"
                }
            };

        
    }
}