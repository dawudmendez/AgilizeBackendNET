using Model.Entities;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PersonService : IPersonService
    {
        public async Task DeleteByIdAsync(int Id)
        {
            await Task.Yield();
            throw new NotImplementedException();
            
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            await Task.Yield();

            throw new NotImplementedException();
        }

        public async Task<Person> GetByIdAsync(int Id)
        {
            await Task.Yield();

            throw new NotImplementedException();
        }
    }
}
