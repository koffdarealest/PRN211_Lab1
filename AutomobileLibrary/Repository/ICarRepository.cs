﻿using AutomobileLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCar();
        Car GetCarByID(int CarID);
        void InsertCar(Car car);
        void DeleteCar(int CarID);  
        void UpdateCar(Car car);
    }
}
