using Esacco.Contracts;
using Esacco.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esacco.Repository
{
    public class StatusRepo : IStatusRepo
    {
        private readonly ApplicationDbContext _db;
        public StatusRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Status entity)
        {
            var isCReated = _db.Statuses.Add(entity);
            return Save();
        }

        public bool Delete(Status entity)
        {
            _db.Statuses.Remove(entity);
            return Save();
        }

        public ICollection<Status> FindAll()
        {
            var statuses = _db.Statuses.ToList();
            return statuses;
        }

        public Status FindById(int id)
        {
            var status = _db.Statuses.Find(id);
            return status;
        }

        public bool isExists(int id)
        {
            var exists = _db.Statuses.Any(p => p.StatusID == id);
            return exists;
        }

        public bool Save()
        {
            var saveChanges = _db.SaveChanges();
            return saveChanges > 0;
        }

        public bool Update(Status entity)
        {
            _db.Statuses.Update(entity);
            return Save();
        }
    }
}
