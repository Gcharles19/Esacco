using Esacco.Contracts;
using Esacco.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esacco.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly ApplicationDbContext _db;
        public CustomerRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Customer entity)
        {
            var isCReated = _db.Customers.Add(entity);
            return Save();
        }

        public bool Delete(Customer entity)
        {
            _db.Customers.Remove(entity);
            return Save();
        }

        public ICollection<Customer> FindAll()
        {
            var customers = _db.Customers.ToList();
            return customers;
        }

        public Customer FindById(int id)
        {
            var customer = _db.Customers.Find(id);
            /*var customer = _db.Customers
                            .Include(q => q.Room)
                            .FirstOrDefault(p => p.CustomerID == id);*/
            return customer;
        }

        public bool isExists(int id)
        {
            var exists = _db.Customers.Any(p => p.CustomerID == id);
            return exists;
        }

        public bool Save()
        {
            var saveChanges = _db.SaveChanges();
            return saveChanges > 0;
        }

        public bool Update(Customer entity)
        {
            _db.Customers.Update(entity);
            return Save();
        }
    }
}
