using Esacco.Contracts;
using Esacco.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esacco.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _db;
        public EmployeeRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Employee entity)
        {
            var isCReated = _db.Employees.Add(entity);
            return Save();
        }

        public bool Delete(Employee entity)
        {
            _db.Employees.Remove(entity);
            return Save();
        }

        public ICollection<Employee> FindAll()
        {
            var employees = _db.Employees.ToList();
            return employees;
        }

        public Employee FindById(int id)
        {
            var employee = _db.Employees.Find(id);
            return employee;
        }

        public bool isExists(int id)
        {
            var exists = _db.Employees.Any(p => p.Id == id.ToString());
            return exists;
        }

        public bool Save()
        {
            var saveChanges = _db.SaveChanges();
            return saveChanges > 0;
        }

        public bool Update(Employee entity)
        {
            _db.Employees.Update(entity);
            return Save();
        }
    }
}
