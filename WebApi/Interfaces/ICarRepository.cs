using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable GetCars();

        void Add(Car car);

        void Remove(string carId);

        void Update(Car car);


    }
}
