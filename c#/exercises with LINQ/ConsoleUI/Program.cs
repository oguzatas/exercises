
using ConsoleUI;

class Program
{
    static void Main(string[] args)
    {


        List<Car> cars = new List<Car>()
        {
            new Car { Id = 1, BrandId = 14324, Description = "Ford", ModelYear = 2008, ColorId = 15 },
                new Car { Id = 2, BrandId = 1, Description = "Audi", ModelYear = 1996, ColorId = 3 },
                new Car { Id = 3, BrandId = 1, Description = "Opel", ModelYear = 1999, ColorId = 2 },
                new Car { Id = 4, BrandId = 2, Description = "Ferrari", ModelYear = 2022, ColorId = 65 },
                new Car { Id = 5, BrandId = 2, Description = "Lamborghini", ModelYear = 2020, ColorId = 1 },
        };

        // AnyTest(cars);

        //FindTest(cars);

        //FindAllTest(cars);



    }

    private static void FindAllTest(List<Car> cars)
    {
        cars.FindAll(p => p.BrandId == 2); // Finds all elements that matches
    }

    private static void FindTest(List<Car> cars)
    {
        var result = cars.Find(p => p.Id == 2); // Finds any element match. returns the first match. If there's no one, returns null
    }

    private static void AnyTest(List<Car> cars)
    {
        var result = cars.Any(p => p.Description == "Ford"); //Checks and  if there's any element match. If finds returns 1
    }

}



    
    
    





