using Activity2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services
{
    interface IMobilityDataService
    {
        List<CarModel> GetAllCars();
        List<CarModel> SearchCars(String search);
        CarModel GetCarById(int id);

        int InsertCar(CarModel car);
        int UpdateCar(CarModel car);

        int DeleteCar(CarModel car);

    }
}
