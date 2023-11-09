using System;

class Car
{
    public int Year;
    public double Price;
    public string Color;
    public string Condition;
}

class CarSale
{
    static void Main()
    {
        // Creating an array of 20 Car objects
        Car[] cars = new Car[20];

        // Initializing the cars with some sample data
        cars[0] = new Car { Year = 2020, Price = 25000.10, Color = "Red", Condition = "New" };
        cars[1] = new Car { Year = 2018, Price = 18000.50, Color = "Blue", Condition = "Used" };
        cars[2] = new Car { Year = 2005, Price = 24000.24, Color = "Black", Condition = "New" };
        cars[3] = new Car { Year = 2006, Price = 21000.75, Color = "Green", Condition = "Used" };
        cars[4] = new Car { Year = 2000, Price = 22000.90, Color = "Red", Condition = "Used" };
        cars[5] = new Car { Year = 2023, Price = 45000.45, Color = "Black", Condition = "Used" };
        cars[6] = new Car { Year = 2022, Price = 28000.75, Color = "Blue", Condition = "Used" };
        cars[7] = new Car { Year = 2022, Price = 29000.35, Color = "White", Condition = "New" };
        cars[8] = new Car { Year = 2023, Price = 66000.75, Color = "Red", Condition = "New" };
        cars[9] = new Car { Year = 2020, Price = 23000.50, Color = "Black", Condition = "New" };
        cars[10] = new Car { Year = 2016, Price = 43000.60, Color = "Blue", Condition = "New" };
        cars[11] = new Car { Year = 2004, Price = 12000.75, Color = "White", Condition = "Used" };
        cars[12] = new Car { Year = 2004, Price = 11500.80, Color = "Green", Condition = "Used" };
        cars[13] = new Car { Year = 2007, Price = 16000.90, Color = "Red", Condition = "New" };
        cars[14] = new Car { Year = 2008, Price = 14000.75, Color = "Green", Condition = "New" };
        cars[15] = new Car { Year = 2013, Price = 25000.55, Color = "White", Condition = "Used" };
        cars[16] = new Car { Year = 2015, Price = 37000.95, Color = "Red", Condition = "Used" };
        cars[17] = new Car { Year = 2016, Price = 82000.75, Color = "Black", Condition = "New" };
        cars[18] = new Car { Year = 2013, Price = 22000.85, Color = "Blue", Condition = "Used" };
        cars[19] = new Car { Year = 2001, Price = 11000.15, Color = "White", Condition = "New" };

        var sortedCars = SortCarsByYearAndPrice(cars);

        DisplayCarInformation(sortedCars);

        Car bestCar = FindBestCar(cars);

        DisplayBestCarInformation(bestCar);

        var loanParams = GetLoanParameters();

        var paymentAmount = CalculateMonthlyPayment(loanParams);

        DisplayMonthlyPayment(paymentAmount);
    }

    // Sort cars by year and price
    static Car[] SortCarsByYearAndPrice(Car[] cars)
    {
        return cars.OrderBy(car => car.Year)
                    .ThenByDescending(car => car.Price)
                    .ToArray();
    }

    // Display sorted car list
    static void DisplayCarInformation(Car[] cars)
    {
        foreach (Car car in cars)
        {
            Console.WriteLine($"Car Information: Year {car.Year}, Price ${car.Price}, Color {car.Color}, Condition {car.Condition}");
        }
    }

    // Find the best car
    static Car FindBestCar(Car[] cars)
    {
        return cars.OrderByDescending(car => car.Year)
                    .ThenByDescending(car => car.Price)
                    .FirstOrDefault();
    }

    // Display information about the best car
    static void DisplayBestCarInformation(Car bestCar)
    {
        if (bestCar != null)
        {
            Console.WriteLine($"Information about the Best Car: Year {bestCar.Year}, Price ${bestCar.Price}, Color {bestCar.Color}, Condition {bestCar.Condition}");
        }
        else
        {
            Console.WriteLine("No cars in the array.");
        }
    }

    // Get loan parameters from the user
    static (double, double, int) GetLoanParameters()
    {
        double loanAmount, interest;
        int numberOfYears;

        Console.Write("Enter the loan amount: $");
        if (!double.TryParse(Console.ReadLine(), out loanAmount))
        {
            Console.WriteLine("Invalid input for loan amount. Please enter a valid number.");
        }

        Console.Write("Enter the interest rate (%): ");
        if (!double.TryParse(Console.ReadLine(), out interest))
        {
            Console.WriteLine("Invalid input for interest rate. Please enter a valid number.");
        }

        Console.Write("Enter the number of years for the loan: ");
        if (!int.TryParse(Console.ReadLine(), out numberOfYears))
        {
            Console.WriteLine("Invalid input for the number of years. Please enter a valid integer number.");
        }

        return (loanAmount, interest, numberOfYears);
    }

    // Calculate monthly payment 
    static double CalculateMonthlyPayment((double loanAmount, double interest, int numberOfYears) loanParams)
    {
        var (loanAmount, interest, numberOfYears) = loanParams;
        var rateOfInterest = interest / 1200;
        var numberOfPayments = numberOfYears * 12;

        return (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));
    }

    // Display monthly payment
    static void DisplayMonthlyPayment(double paymentAmount)
    {
        Console.WriteLine($"Monthly payment amount: {paymentAmount:C}");
    }

}