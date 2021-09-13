using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryCarDal
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;
		public InMemoryCarDal()
		{
			_cars = new List<Car> { 
				new Car{CarId=1,BrandId=1,ModelYear=2015,ColorId=1,DailyPrice=100,Description="Siyah Opel Sedan"},
				new Car{CarId=2,BrandId=1,ModelYear=2018,ColorId=2,DailyPrice=120,Description="Beyaz Opel Spor"},
				new Car{CarId=3,BrandId=2,ModelYear=2010,ColorId=1,DailyPrice=150,Description="Siyah Mercedes Sedan"},
				new Car{CarId=4,BrandId=2,ModelYear=2020,ColorId=3,DailyPrice=200,Description="Kırmızı Mercedes E200"},
				new Car{CarId=5,BrandId=3,ModelYear=2019,ColorId=1,DailyPrice=175,Description="Siyah BMV 520"}
			};
		}
		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
			_cars.Remove(carToDelete);
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetById(int Id)
		{
			return _cars.Where(c=>c.CarId==Id).ToList();
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
			carToUpdate.CarId = car.CarId;
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.ModelYear = car.ModelYear;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;
		}
	}
}
