using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TaskServices : ITaskServices
    {
        private readonly ITaskServices _taskRepository;
        public TaskServices(ITaskServices taskRepository)
        {
            _taskRepository = taskRepository;
        }


        public async Task<Tasks> CreateAsync(Tasks task)
        {
            // throw new NotImplementedException();
            return await _taskRepository.CreateAsync(task);
        }

        public async Task<int> DeleteAsync(int id)
        {
            //throw new NotImplementedException();
            return await _taskRepository.DeleteAsync(id);

        }

        public async Task<List<Tasks>> GetAllAsync()
        {
           // throw new NotImplementedException();

            return await _taskRepository.GetAllAsync();
        }

        public async Task<Tasks> GetByIdAsync(int Id)
        {
            // throw new NotImplementedException();

            return await _taskRepository.GetByIdAsync(Id);

        }

        public async Task<int> UpdateAsync(int id, Tasks task)
        {
            /// throw new NotImplementedException();
            return await _taskRepository.UpdateAsync(id, task);

        }
    }  
}
