using ModularTasks.Core.Entities.ModularTasks.Core.Entities;
using ModularTasks.Core.Interfaces;

namespace ModularTasks.Infrastructure.Repositories
{
    public class InMemoryTaskStore : ITaskRepository
    {
        private readonly Dictionary<Guid, TaskItem> _tasks = new();
        public Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return Task.FromResult(_tasks.Values.AsEnumerable());
        }
        public Task<TaskItem?> GetByIdAsync(Guid id)
        {
            _tasks.TryGetValue(id, out var task);
            return Task.FromResult(task);
        }
        public Task AddAsync(TaskItem task)
        {
            _tasks[task.Id] = task;
            return Task.CompletedTask;
        }
        public Task UpdateAsync(TaskItem task)
        {
            if (_tasks.ContainsKey(task.Id))
            {
                _tasks[task.Id] = task;
            }
            return Task.CompletedTask;
        }
        public Task DeleteAsync(Guid id)
        {
            _tasks.Remove(id);
            return Task.CompletedTask;
        }
    }
}
