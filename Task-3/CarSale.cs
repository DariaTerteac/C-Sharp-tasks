using System;

class Car
{
    public string? Manufacturer { get; set; }
    public string? CarType { get; set; }
    public string? Model { get; set; }
    public string? Completion { get; set; }
    public double? EngineCapacity { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public string? Color { get; set; }
    public string? Condition { get; set; }

    public static void SortAndDisplayCars(Car[] cars)
    {
        // Sort cars by year and price
        var sortedCars = cars.OrderBy(car => car.Year)
                            .ThenByDescending(car => car.Price)
                            .ToArray();

        // Display sorted car list
        foreach (Car car in sortedCars)
            Console.WriteLine($"Car Information: Manufacturer {car.Manufacturer}, Car type {car.CarType}, Model {car.Model}, Completion {car.Completion}, Year {car.Year}, Engine capacity {car.EngineCapacity}, Price ${car.Price}, Color {car.Color}, Condition {car.Condition}");
    }

    public static void FindAndDisplayBestCar(Car[] cars)
    {
        // Find the best car
        var bestCar = cars.OrderByDescending(car => car.Year)
                         .ThenByDescending(car => car.Price)
                         .FirstOrDefault();

        // Display information about the best car
        if (bestCar != null)
            Console.WriteLine($"Information about the Best Car: Manufacturer {bestCar.Manufacturer}, Car type {bestCar.CarType}, Model {bestCar.Model}, Completion {bestCar.Completion}, Year {bestCar.Year}, Engine capacity {bestCar.EngineCapacity}, Price ${bestCar.Price}, Color {bestCar.Color}, Condition {bestCar.Condition}");
        else
            Console.WriteLine("No cars in the array.");
    }
}

class CarSale
{
    static void Main()
    {
        Car[] cars =
        [
            new Car { Manufacturer = "Chery", CarType = "Crossover", Model = "Tiggo 8 Pro e+", Completion = "Standart", Year = 2023, EngineCapacity = 1.5, Price = 37500, Color = "Red", Condition = "New" },
            new Car { Manufacturer = "Chery", CarType = "Crossover", Model = "Tiggo 8 Pro e+", Completion = "Standart", Year = 2021, EngineCapacity = 1.5, Price = 35500, Color = "Purple", Condition = "Used" },
            new Car { Manufacturer = "Chery", CarType = "Crossover", Model = "Tiggo 8 Pro MAX", Completion = "Standart", Year = 2023, EngineCapacity = 2.0, Price = 30700, Color = "Black", Condition = "New" },
            new Car { Manufacturer = "Chery", CarType = "Crossover", Model = "Tiggo 8 Pro MAX", Completion = "Standart", Year = 2022, EngineCapacity = 2.0, Price = 29500, Color = "White", Condition = "New" },
            new Car { Manufacturer = "Chery", CarType = "Crossover", Model = "Tiggo 8 Pro", Completion = "Standart", Year = 2022, EngineCapacity = 1.6, Price = 21700, Color = "Blue", Condition = "Used" },
            new Car { Manufacturer = "Chery", CarType = "Crossover", Model = "Tiggo 8 Pro", Completion = "Standart", Year = 2023, EngineCapacity = 1.6, Price = 23700, Color = "Gray", Condition = "New" },
            new Car { Manufacturer = "Chery", CarType = "Crossover", Model = "Tiggo 7 Pro", Completion = "Premium", Year = 2022, EngineCapacity = 1.5, Price = 20800, Color = "Blue premium", Condition = "Used" },
            new Car { Manufacturer = "Chery", CarType = "Crossover", Model = "Tiggo 2 Pro", Completion = "Standart", Year = 2022, EngineCapacity = 1.5, Price = 12900, Color = "Silver", Condition = "New" },
            new Car { Manufacturer = "Haval", CarType = "Crossover", Model = "Jolion", Completion = "Comfort", Year = 2021, EngineCapacity = 1.5, Price = 15900, Color = "Green", Condition = "Used" },
            new Car { Manufacturer = "Haval", CarType = "Crossover", Model = "Jolion", Completion = "Top", Year = 2023, EngineCapacity = 1.5, Price = 19900, Color = "Hamilton White", Condition = "New" },
            new Car { Manufacturer = "Haval", CarType = "Crossover", Model = "M6", Completion = "Premium", Year = 2021, EngineCapacity = 1.5, Price = 16500, Color = "Black", Condition = "New" },
            new Car { Manufacturer = "Haval", CarType = "Crossover", Model = "M6", Completion = "Premium", Year = 2023, EngineCapacity = 1.5, Price = 16500, Color = "Red", Condition = "Used" },
            new Car { Manufacturer = "Haval", CarType = "Crossover", Model = "H6 GT", Completion = "Top", Year = 2023, EngineCapacity = 1.5, Price = 28500, Color = "Blue", Condition = "New" },
            new Car { Manufacturer = "Haval", CarType = "Crossover", Model = "H9 FL", Completion = "Super-Dignity", Year = 2023, EngineCapacity = 1.5, Price = 35500, Color = "Gray", Condition = "New" },
            new Car { Manufacturer = "Haval", CarType = "Crossover", Model = "Dargo", Completion = "Top", Year = 2023, EngineCapacity = 2.0, Price = 26500, Color = "Orange", Condition = "Used" },
            new Car { Manufacturer = "Geely", CarType = "Crossover", Model = "Altas Pro", Completion = "Luxury", Year = 2023, EngineCapacity = 1.5, Price = 24880, Color = "Red mettalic", Condition = "New" },
            new Car { Manufacturer = "Geely", CarType = "Crossover", Model = "Coolray", Completion = "Flagship", Year = 2023, EngineCapacity = 1.5, Price = 20880, Color = "Purple grey", Condition = "Used" },
            new Car { Manufacturer = "Geely", CarType = "Crossover", Model = "Tugella", Completion = "Flagship +", Year = 2023, EngineCapacity = 2.0, Price = 34880, Color = "Light grey", Condition = "New" },
            new Car { Manufacturer = "Geely", CarType = "Crossover", Model = "Monjaro", Completion = "Flagship", Year = 2023, EngineCapacity = 2.0, Price = 42500, Color = "Crystal turquoise", Condition = "New" },
        ];

        Car.SortAndDisplayCars(cars);

        Car.FindAndDisplayBestCar(cars);

        CalculateLoan(cars);
    }

    // Get loan parameters
    static (double basePayment, int numberOfMonths) GetLoanParameters()
    {
        double basePayment;
        int numberOfMonths;

        Console.Write("Enter the base payment: $");
        if (!double.TryParse(Console.ReadLine(), out basePayment))
            Console.WriteLine("Invalid input for base amount. Please enter a valid number.");

        Console.Write("Enter the number of months for the loan: ");
        if (!int.TryParse(Console.ReadLine(), out numberOfMonths))
            Console.WriteLine("Invalid input for the number of months. Please enter a valid integer number.");

        return (basePayment, numberOfMonths);
    }

    static void CalculateLoan(Car[] cars)
    {
        // Get loan parameters from the user
        (double basePayment, int numberOfMonths) loanParams = GetLoanParameters();

        // Prompt user to enter car condition
        Console.Write("Enter car condition (New / Used): ");
        string condition = Console.ReadLine()?.Trim() ?? string.Empty;

        // Constant
        const int monthsPerYear = 12;

        // Calculate and store monthly payment for each car based on condition
        var carMonthlyPayments = cars
            .Where(car => car.Condition?.Equals(condition, StringComparison.OrdinalIgnoreCase) ?? false)
            .Select(car =>
            {
                // Calculate loan amount
                double loanAmount = car.Price - loanParams.basePayment;

                // Calculate monthly payment 
                double interestInPercent = 9;
                var rateOfInterest = interestInPercent / monthsPerYear / 100;
                var numberOfPayments = loanParams.numberOfMonths;
                var monthlyPayment = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));

                return (car, monthlyPayment);
            })
            .OrderBy(tuple => tuple.Item2) // Sort by monthly payment
            .ToList();

        // Display sorted monthly payments
        foreach (var (car, monthlyPayment) in carMonthlyPayments)
        {
            Console.WriteLine($"Monthly payment for {car.Manufacturer} {car.Model} {car.Year}({car.Condition}): {monthlyPayment:C}");
        }
    }
}
