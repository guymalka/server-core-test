using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class SampleData
    {
                
        public List<Car> cars = null;
        public List<Location> locations = null;
        public List<CarRental> rentals = null;
        SampleData()
        {
            
            locations = new List<Location>();
            locations.Add(new Location { CityId = 1, CityName = "tel aviv", MinimumAge = 21 });
            locations.Add(new Location { CityId = 2, CityName = "new york", MinimumAge = 22 });
            locations.Add(new Location { CityId = 3, CityName = "amsterdam", MinimumAge = 19 });
            locations.Add(new Location { CityId = 4, CityName = "bergen", MinimumAge = 18 });
            locations.Add(new Location { CityId = 5, CityName = "saloniky", MinimumAge = 24 });

            cars = new List<Car>();
            cars.Add(new Car { CarGroup = CarGroup.Family, CarID = "20-608-20", Location = locations.First(m =>  m.CityId ==1)  });
            cars.Add(new Car { CarGroup = CarGroup.Family, CarID = "20-608-21", Location = locations.First(m => m.CityId == 2) });
            cars.Add(new Car { CarGroup = CarGroup.Family, CarID = "220-08-110", Location = locations.First(m => m.CityId == 3) });
            cars.Add(new Car { CarGroup = CarGroup.Family, CarID = "220-12-176", Location = locations.First(m => m.CityId == 4) });
            cars.Add(new Car { CarGroup = CarGroup.Family, CarID = "220-34-276", Location = locations.First(m => m.CityId == 5) });

            
            rentals = new List<CarRental>();
        }
    }
}
