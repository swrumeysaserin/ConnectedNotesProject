using ConnectedNotesProject.Bussiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedNotesProject.Bussiness.Concrete
{
    public class GenericRepository<T> : IGenericService<T> where T : class
    {
        Context _database;

        public GenericRepository(Context database)
        {
            _database = database;
        }

        public T Create(T t)
        {
            _database.Add(t);
            _database.SaveChanges();
            return t;
        }

        public void Delete(T t)
        {
            _database.Remove(t);
            _database.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _database.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _database.Set<T>().Find(id);
        }

        public T Update(T t)
        {
            _database.Update(t);
            _database.SaveChanges();
            return t;
        }
    }
}
