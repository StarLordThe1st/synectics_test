using synactics_test;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Synectics Statistics Tool");
        Console.Write("Please enter the path of the sales file: ");
        string filePath = Console.ReadLine()!;
        while (!InputValidator.IsFilePathValid(filePath)){
            Console.WriteLine("Invalid file path.");
            Console.Write("Please enter the path of the sales file: ");
            filePath = Console.ReadLine()!;
        }

        FileReader fileReader = new FileReader();
        string fileContent = fileReader.ReadFile(filePath);

        List<Sales> salesList = new List<Sales>();
        string[] lines = fileContent.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

        foreach (string line in lines)
        {
            string[] parts = line.Split("##");
            
            if (DateTime.TryParse(parts[0], out DateTime dateTime))
            {
                DateOnly date = DateOnly.FromDateTime(dateTime);
                if (decimal.TryParse(parts[1], out decimal price))
                {
                    salesList.Add(new Sales(date, price));
                }
            }
        }

        Console.WriteLine("\nAvailable Operations: \n1. Average earnings per range of years\n2. Standard deviation of earnings within a year\n3. Standard deviation of earnings within a range of years\n4. Exit");
        Console.Write("\nPlease enter the operation number: ");
        string option = Console.ReadLine()!;

        while (option != "4"){
            switch (option){
                case "1":
                    Console.Write("Enter start year: ");
                    string input = Console.ReadLine()!;

                    while (InputValidator.IsValidYear(input)){
                        Console.WriteLine("Invalid year. Please enter a valid year.");
                        Console.Write("Enter start year: ");
                        input = Console.ReadLine()!;
                    }

                    int startYear = int.Parse(input);
                
                    Console.Write("Enter end year: ");
                    input = Console.ReadLine()!;

                    while (InputValidator.IsValidYear(input)){
                        Console.WriteLine("Invalid year. Please enter a valid year.");
                        Console.Write("Enter start year: ");
                        input = Console.ReadLine()!;
                    }

                    int endYear = int.Parse(input);

                    decimal averageEarnings = StatisticsGenerator.CalculateAverageEarningsPerYear(salesList, startYear, endYear);
                    Console.WriteLine($"\nAverage earnings from {startYear} to {endYear}: {averageEarnings:F2}");
                    break;
                case "2":
                    Console.Write("Enter year: ");
                    string input2 = Console.ReadLine()!;

                    while (InputValidator.IsValidYear(input2)){
                        Console.WriteLine("Invalid year. Please enter a valid year.");
                        Console.Write("Enter year: ");
                        input2 = Console.ReadLine()!;
                    }

                    int year = int.Parse(input2);

                    decimal standardDeviation = StatisticsGenerator.CalculateStandardDeviationEarningsPerYear(salesList, year);
                    Console.WriteLine($"\nStandard deviation of earnings in {year}: {standardDeviation:F2}");
                    break;
                case "3":
                    Console.Write("Enter start year: ");
                    string input3 = Console.ReadLine()!;

                    while (InputValidator.IsValidYear(input3)){
                        Console.WriteLine("Invalid year. Please enter a valid year.");
                        Console.Write("Enter start year: ");
                        input3 = Console.ReadLine()!;
                    }

                    int startYear2 = int.Parse(input3);
                
                    Console.Write("Enter end year: ");
                    input = Console.ReadLine()!;

                    while (InputValidator.IsValidYear(input)){
                        Console.WriteLine("Invalid year. Please enter a valid year.");
                        Console.Write("Enter start year: ");
                        input = Console.ReadLine()!;
                    }

                    int endYear2 = int.Parse(input);
                    decimal standardDeviation2 = StatisticsGenerator.CalculateStandardDeviationEarningsPerYear(salesList, startYear2, endYear2);
                    Console.WriteLine($"\nStandard deviation of earnings from {startYear2} to {endYear2}: {standardDeviation2:F2}");
                    break;
                default:
                    Console.WriteLine("\nInvalid option selected.");
                    break;
                }
                Console.Write("\nMake another operation? (y/n): ");
                string anotherOperation = Console.ReadLine()!;
                if (anotherOperation.ToLower() == "y"){
                    Console.WriteLine("\nAvailable Operations: \n1. Average earnings per range of years\n2. Standard deviation of earnings within a year\n3. Standard deviation of earnings within a range of years\n4. Exit");
                    Console.Write("\nPlease enter the operation number: ");
                    option = Console.ReadLine()!;
                }
                else if (anotherOperation.ToLower() == "n"){
                    break; 
                }
                else {
                    Console.WriteLine("\nInvalid option selected.");
                }
            
        }

        Console.Write("\nThanks for using the Synectics Statistics Tool! Press any key to exit.");
        Console.ReadKey();
        Console.WriteLine();
    }
}



