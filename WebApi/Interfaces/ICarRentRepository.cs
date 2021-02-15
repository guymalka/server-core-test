using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Interfaces
{
    public interface ICarRentRepository
    {
        void Add(CarRental carRental);
        void Remove(int id);
        void Update(CarRental car);
        List<CarRental> FindAvailableRentals(DateTime fromdate, DateTime todate, short cityId, short dirverage);
    }
}
