using Esacco.Contracts;
using Esacco.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esacco.Repository
{
    public class SysConfigRepo : ISysConfigRepo
    {
        private readonly ApplicationDbContext _db;
        public SysConfigRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(SysConfig entity)
        {
            var isCReated = _db.SysConfigs.Add(entity);
            return Save();
        }

        public bool Delete(SysConfig entity)
        {
            _db.SysConfigs.Remove(entity);
            return Save();
        }

        public ICollection<SysConfig> FindAll()
        {
            var sysConfigs = _db.SysConfigs.ToList();
            return sysConfigs;
        }

        public SysConfig FindById(int id)
        {
            var status = _db.SysConfigs.Find(id);
            return status;
        }

        public bool isExists(int id)
        {
            var exists = _db.SysConfigs.Any(p => p.Id == id);
            return exists;
        }

        public bool Save()
        {
            var saveChanges = _db.SaveChanges();
            return saveChanges > 0;
        }

        public bool Update(SysConfig entity)
        {
            _db.SysConfigs.Update(entity);
            return Save();
        }
    }
}
