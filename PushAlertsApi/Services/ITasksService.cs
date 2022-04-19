﻿using PushAlertsApi.Models;
using Task = PushAlertsApi.Models.Task;


namespace PushAlertsApi.Services
{
    public interface ITasksService
    {
        /// <summary>
        /// Adds the given task to the given project
        /// </summary>
        /// <param name="project"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        public Task AddTask(Project project, Task task);

        /// <summary>
        /// Assigns the given task to given user
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="user"></param>
        public void AssignTask(string uuid, User user);

        /// <summary>
        /// Closes the task with the given uuid and set state to done or rejected
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="status"></param>
        public void CloseTask(string uuid, TaskState status);

        /// <summary>
        /// Returns the task with the given UUID
        /// </summary>
        /// <param name="uuid">A unique identifier for a task</param>
        /// <returns></returns>
        public Task GetTask(string uuid);
    }
}
