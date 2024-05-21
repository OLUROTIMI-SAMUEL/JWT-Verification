using Application.Contract;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    /*
    public class TaskRepository : ITask
    {
        private readonly AppDbContext _taskDbContext;
        public TaskRepository(AppDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<Tasks> CreateAsync(Tasks task)
        {
            // throw new NotImplementedException();
            await _taskDbContext.Tasks.AddAsync(task);
            await _taskDbContext.SaveChangesAsync();
            return task;
        }

        public async Task<int> DeleteAsync(int id)
        {
            // throw new NotImplementedException();
            return await _taskDbContext.Tasks.Where(model => model.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Tasks>> GetAllAsync()
        {
            // throw new NotImplementedException();

            return await _taskDbContext.Tasks.ToListAsync();
        }

        public async Task<Tasks> GetByIdAsync(int Id)
        {
            // throw new NotImplementedException();

            return await _taskDbContext.Tasks.AsNoTracking().FirstOrDefaultAsync(b => b.Id == Id);
        }

        public async Task<int> UpdateAsync(int id, Tasks task)
        {
           // throw new NotImplementedException();
           return await _taskDbContext.Tasks
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                .SetProperty(a => a.Id, task.Id)
                .SetProperty(a => a.Name, task.Name)
                .SetProperty(a => a.NumberOfTask, task.NumberOfTask)
                .SetProperty(a => a.Description, task.Description)
                .SetProperty(a => a.DateOfTask, task.DateOfTask)
                );

        }
    }
    */
}
