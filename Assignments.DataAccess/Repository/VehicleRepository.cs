using Assignments.DataAccess.Data;
using Assignments.DataAccess.Repository.IRepository;
using Assignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DataAccess.Repository
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        private ApplicationDbContext _db;
        public VehicleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       

        public void Update(Vehicle obj)
        {
            var objFromDb = _db.Vehicles.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.Make = obj.Make;
                objFromDb.Model = obj.Model;
                objFromDb.LicenseNo = obj.LicenseNo;
                objFromDb.Year = obj.Year;
                objFromDb.EngineSize = obj.EngineSize;
                objFromDb.Transmission = obj.Transmission;
                objFromDb.Features = obj.Features;
                objFromDb.AdditionalInformation = obj.AdditionalInformation;
                objFromDb.Color = obj.Color;
                objFromDb.Mileage = obj.Mileage;
                objFromDb.AskingPrice = obj.AskingPrice;
                if(obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
