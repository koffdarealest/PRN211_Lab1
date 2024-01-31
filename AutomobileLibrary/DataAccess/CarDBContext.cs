using AutomobileLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        private static List<Car> CarList = new List<Car>()
        {
            new Car { CarID = 1, CarName = "Civic", Manufacturer = "Honda", Price = 20000, ReleaseYear = 2015 },
            new Car { CarID = 2, CarName = "Ford Focus", Manufacturer = "Ford", Price = 25000, ReleaseYear = 2016 },
        };
        // Singleton pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        //-------------------------------------------
        public List<Car> GetCarList()
        {
            return CarList;
        }
        //--------------------------------------------  
        public Car GetCarByID(int id)
        {
            Car car = CarList.SingleOrDefault(c => c.CarID == id);
            return car;
        }   
        //--------------------------------------------
        //Add a new car
        public void AddCar(Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if (pro == null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("Car already exists");
            }
        }   
        //--------------------------------------------
        //Update a car
        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if (c != null)
            {
                var index = CarList.IndexOf(c);
                CarList[index] = car;
            } 
            else
            {
                throw new Exception("Car not found");
            }   
        }
        //---------------------------------------------
        //Remove a car
        public void Remove(int CarID)
        {
            Car p = GetCarByID(CarID);
            if (p != null)
            {
                CarList.Remove(p);
            }
            else { throw new Exception("Car does not exists."); }
        }
        //----------------------------------------------
        //end class
    };

}
