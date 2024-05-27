using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;

namespace UMS_DAL.Repository._GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class 
    {
        public readonly DbSet<T> _dbset;
        public readonly UniversityMsContext _context;

        public GenericRepository(UniversityMsContext context)
        {
            _dbset = context.Set<T>();
            _context = context;
        }

        #region Get
        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }
        public T GetByID(int id)
        {
            return _dbset.Find(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }



        #endregion

        #region ADD 
        public T Add(T t)
        {
            try { 
            var result = _dbset.Add(t); // add method have changed the reference of  the T 
            _context.SaveChanges();
                return result.Entity;
                //return T
            }
            catch(Exception ex) //middlewear
            {
                throw new Exception();
            }
        }
        #endregion

        #region Update
        public T Update(T t)
        {
            try { 
            _dbset.Update(t);
            _context.SaveChanges();
                return t;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        #endregion

        #region Delete
        public int Delete(T t)
        {
            try
            {
                if(t != null) { 
                _dbset.Remove(t);
                _context.SaveChanges();
                return 1;
                }
                else {
                    return 0;
                }
            }

            catch(Exception ex)
            {
                throw new Exception();
            }

        }

        public int Delete(int id)
        {
            try
            {
                var entity = GetByID(id);
                return Delete(entity);
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }


        #endregion
    }
    
}
