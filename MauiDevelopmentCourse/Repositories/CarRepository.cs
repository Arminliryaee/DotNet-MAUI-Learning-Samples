using MauiDevelopmentCourse.Models;

namespace MauiDevelopmentCourse.Repositories
{
    public class CarRepository
    {
        public List<Car> GetCars() => [
                new(){ Id = Guid.NewGuid(), Name = "Car 1", Brand = "Toyota", Model = "Corolla", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 2", Brand = "Toyota", Model = "Camry", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 3", Brand = "Honda", Model = "Civic", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 4", Brand = "Honda", Model = "Accord", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 5", Brand = "Mazda", Model = "CX-5", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 6", Brand = "Mazda", Model = "3", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 7", Brand = "BMW", Model = "320i", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 8", Brand = "BMW", Model = "X5", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 9", Brand = "Mercedes", Model = "C200", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 10", Brand = "Mercedes", Model = "E300", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 11", Brand = "Audi", Model = "A4", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 12", Brand = "Audi", Model = "Q5", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 13", Brand = "Hyundai", Model = "Elantra", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 14", Brand = "Hyundai", Model = "Tucson", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 15", Brand = "Kia", Model = "Sportage", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 16", Brand = "Kia", Model = "Sorento", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 17", Brand = "Volkswagen", Model = "Golf", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 18", Brand = "Volkswagen", Model = "Passat", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 19", Brand = "Peugeot", Model = "208", CreatedDate = DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "Car 20", Brand = "Peugeot", Model = "3008", CreatedDate = DateTime.UtcNow },
            ];
    }
}
