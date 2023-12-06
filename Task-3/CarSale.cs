using System;

class Car
{
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public string Color { get; set; }
    public string Condition { get; set; }

    public static void SortAndDisplayCars(Car[] cars)
    {
        // Sort cars by year and price
        var sortedCars = cars.OrderBy(car => car.Year)
                            .ThenByDescending(car => car.Price)
                            .ToArray();

        // Display sorted car list
        foreach (Car car in sortedCars)
            Console.WriteLine($"Car Information: Manufacturer {car.Manufacturer}, Year {car.Year}, Price ${car.Price}, Color {car.Color}, Condition {car.Condition}");
    }

    public static void FindAndDisplayBestCar(Car[] cars)
    {
        // Find the best car
        var bestCar = cars.OrderByDescending(car => car.Year)
                         .ThenByDescending(car => car.Price)
                         .FirstOrDefault();

        // Display information about the best car
        if (bestCar != null)
            Console.WriteLine($"Information about the Best Car: Manufacturer {bestCar.Manufacturer}, Year {bestCar.Year}, Price ${bestCar.Price}, Color {bestCar.Color}, Condition {bestCar.Condition}");
        else
            Console.WriteLine("No cars in the array.");
    }
}

class CarSale
{
    static void Main()
    {
        // Creating an array of 20 Car objects
        Car[] cars = new Car[20];

        // Initializing the cars with some sample data
        cars[0] = new Car { Manufacturer = "BYD", Year = 2020, Price = 25000.10, Color = "Red", Condition = "New" };
        cars[1] = new Car { Manufacturer = "Geely", Year = 2018, Price = 18000.50, Color = "Blue", Condition = "Used" };
        cars[2] = new Car { Manufacturer = "GWM", Year = 2005, Price = 24000.24, Color = "Black", Condition = "New" };
        cars[3] = new Car { Manufacturer = "Changan", Year = 2006, Price = 21000.75, Color = "Green", Condition = "Used" };
        cars[4] = new Car { Manufacturer = "Chery", Year = 2000, Price = 22000.90, Color = "Red", Condition = "Used" };
        cars[5] = new Car { Manufacturer = "NIO", Year = 2023, Price = 45000.45, Color = "Black", Condition = "Used" };
        cars[6] = new Car { Manufacturer = "Geely", Year = 2022, Price = 28000.75, Color = "Blue", Condition = "Used" };
        cars[7] = new Car { Manufacturer = "Lynk & Co", Year = 2022, Price = 29000.35, Color = "White", Condition = "New" };
        cars[8] = new Car { Manufacturer = "Haval", Year = 2023, Price = 66000.75, Color = "Red", Condition = "New" };
        cars[9] = new Car { Manufacturer = "Haval", Year = 2020, Price = 23000.50, Color = "Black", Condition = "Used" };
        cars[10] = new Car { Manufacturer = "SWM Motors", Year = 2016, Price = 43000.60, Color = "Blue", Condition = "New" };
        cars[11] = new Car { Manufacturer = "JAC Motors", Year = 2004, Price = 12000.75, Color = "White", Condition = "Used" };
        cars[12] = new Car { Manufacturer = "DFM", Year = 2004, Price = 11500.80, Color = "Green", Condition = "Used" };
        cars[13] = new Car { Manufacturer = "SAIC Motor", Year = 2007, Price = 16000.90, Color = "Red", Condition = "New" };
        cars[14] = new Car { Manufacturer = "Chery", Year = 2008, Price = 14000.75, Color = "Green", Condition = "New" };
        cars[15] = new Car { Manufacturer = "BYD", Year = 2013, Price = 25000.55, Color = "White", Condition = "Used" };
        cars[16] = new Car { Manufacturer = "GWM", Year = 2015, Price = 37000.95, Color = "Red", Condition = "Used" };
        cars[17] = new Car { Manufacturer = "Geely", Year = 2016, Price = 82000.75, Color = "Black", Condition = "New" };
        cars[18] = new Car { Manufacturer = "NIO", Year = 2013, Price = 22000.85, Color = "Blue", Condition = "Used" };
        cars[19] = new Car { Manufacturer = "Geely", Year = 2001, Price = 11000.15, Color = "White", Condition = "New" };

        Car.SortAndDisplayCars(cars);

        Car.FindAndDisplayBestCar(cars);

        CalculateLoan();
    }

    // Get loan parameters
    static (double fullPrice, double basePayment, int numberOfMonths) GetLoanParameters()
    {
        double fullPrice, basePayment;
        int numberOfMonths;

        Console.Write("Enter the full price of the car: $");
        if (!double.TryParse(Console.ReadLine(), out fullPrice))
            Console.WriteLine("Invalid input for full price. Please enter a valid number.");

        Console.Write("Enter the base payment: $");
        if (!double.TryParse(Console.ReadLine(), out basePayment))
            Console.WriteLine("Invalid input for base amount. Please enter a valid number.");

        Console.Write("Enter the number of months for the loan: ");
        if (!int.TryParse(Console.ReadLine(), out numberOfMonths))
            Console.WriteLine("Invalid input for the number of months. Please enter a valid integer number.");

        return (fullPrice, basePayment, numberOfMonths);
    }

    static void CalculateLoan()
    {
        // Get loan parameters from the user
        (double fullPrice, double basePayment, int numberOfMonths) loanParams = GetLoanParameters();

        // Calculate loan amount
        double loanAmount = loanParams.fullPrice - loanParams.basePayment;

        // Constant
        const int monthsPerYear = 12;

        // Calculate monthly payment 
        double interestInPercent = 9;
        var rateOfInterest = interestInPercent / monthsPerYear / 100;
        var numberOfPayments = loanParams.numberOfMonths;
        var monthlyPayment = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));

        // Display monthly payment
        Console.WriteLine($"Monthly payment amount: {monthlyPayment:C}");
    }
}
