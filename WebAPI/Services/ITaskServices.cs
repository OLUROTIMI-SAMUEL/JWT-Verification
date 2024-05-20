using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public  interface ITaskServices
    {
        Task<List<Tasks>> GetAllAsync();

        Task<Tasks> GetByIdAsync(int Id);

        Task<Tasks> CreateAsync(Tasks task);

        Task<int> UpdateAsync(int id, Tasks task);

        Task<int> DeleteAsync(int id);



    }
}
