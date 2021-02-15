using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Interfaces;

namespace WebApi.Repositories
{
    public class CarRentRepository : ICarRentRepository
    {
        private readonly SampleData _data;
        public CarRentRepository(SampleData data)
        {
            _data = data;
        }
        public void Add(CarRental carRental)
        {
            _data.rentals.Add(carRental);            
        }

        public List<CarRental> FindAvailableRentals(DateTime fromdate, DateTime todate, short cityId, short dirverage)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            if (_data.rentals.Any(m => m.id == id))
                _data.rentals.Remove(_data.rentals.First(m => m.id == id));                                
        }

        public void Update(CarRental car)
        {
            if (_data.rentals.Any(m => m.id == car.id))
            {
                _data.rentals.Remove(_data.rentals.First(m => m.id == car.id));
                _data.rentals.Add(car);
            }
                
        }
    }
}
