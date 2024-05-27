using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;

namespace UMS_DAL.Repository._GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        T GetByID(int id);

        T Add(T T);

        T Update(T t);

        int Delete(T t);

        int Delete(int id);
    }
}
