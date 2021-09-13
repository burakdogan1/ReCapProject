using Business.Concrete;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new InMemoryCarDal());
			Car car1 = new Car() {BrandId=7,CarId=7,ColorId=7,DailyPrice=700,ModelYear=2017,Description="Sarı Audi Sedan"};


			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine(car.Description);
			}
		}
	}
}
