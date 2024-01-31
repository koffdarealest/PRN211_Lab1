using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int CarID)
        {
            return CarDBContext.Instance.GetCarByID(CarID);
        }

        public IEnumerable<Car> GetCar()
        {
            return CarDBContext.Instance.GetCarList();
        }

        public void InsertCar(Car car)
        {
            CarDBContext.Instance.AddCar(car);
        }
        public void UpdateCar(Car car)
        {
            CarDBContext.Instance.Update(car);
        }

        public void DeleteCar(int CarID)
        {
            CarDBContext.Instance.Remove(CarID);
        }
        
    }
}
