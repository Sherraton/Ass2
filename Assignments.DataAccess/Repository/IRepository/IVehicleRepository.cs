using Assignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DataAccess.Repository.IRepository
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        void Update(Vehicle obj);
    }
}
