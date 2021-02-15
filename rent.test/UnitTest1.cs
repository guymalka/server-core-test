using System;
using WebApi;
using WebApi.Interfaces;
using Xunit;

namespace rent.test
{
    public class UnitTest1
    {
        private ICarRentRepository _rentRepository;
        public UnitTest1(ICarRentRepository rentRepo)
        {
            _rentRepository = rentRepo;
         }
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void AddCarRent()
        {
            /*
            _rentRepository.Add(new CarRental { 
                Description = "test rent",
                



            });
            */
        }
    }
}
