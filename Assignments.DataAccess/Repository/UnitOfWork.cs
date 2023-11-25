using Assignments.DataAccess.Data;
using Assignments.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IVehicleRepository Vehicle { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Vehicle = new VehicleRepository(_db);

        }
        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
