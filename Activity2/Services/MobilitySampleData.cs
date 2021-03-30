using Activity2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services
{
    public class MobilitySampleData : IMobilityDataService
    {
        public int DeleteCar(CarModel car)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> GetAllCars()
        {
            // GETTING All Cars
            List<CarModel> cars = new List<CarModel>();

            cars.Add(new CarModel { Id = 1, CarName = "BMW", CarYear = 1985 });
            cars.Add(new CarModel { Id = 2, CarName = "Audi", CarYear = 2000 });
            cars.Add(new CarModel { Id = 3, CarName = "Peugot", CarYear = 1999 });
            cars.Add(new CarModel { Id = 4, CarName = "Mercedes-Benz", CarYear = 2006 });
            cars.Add(new CarModel { Id = 5, CarName = "Renault", CarYear = 2005 });
            cars.Add(new CarModel { Id = 6, CarName = "Ford", CarYear = 2021 });
            cars.Add(new CarModel { Id = 7, CarName = "GMC", CarYear = 2019 });

            return cars;
        }

        public CarModel GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertCar(CarModel car)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> SearchCars(string search)
        {
            throw new NotImplementedException();
        }

        public int UpdateCar(CarModel car)
        {
            throw new NotImplementedException();
        }
    }
}
