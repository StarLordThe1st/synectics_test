namespace synactics_test

{
    public class StatisticsGenerator
    {
        public static decimal CalculateAverageEarningsPerYear(List<Sales> salesList, int startYear, int endYear)
        {
            var filteredSales = salesList.Where(s => s.Date.Year >= startYear && s.Date.Year <= endYear).ToList();
            if (filteredSales.Count == 0) return 0;
            return filteredSales.Average(s => s.Price);
        }

        public static decimal CalculateStandardDeviationEarningsPerYear(List<Sales> salesList, int year)
        {
            var filteredSales = salesList.Where(s => s.Date.Year == year).ToList();
            if (filteredSales.Count == 0) return 0;
            decimal average = filteredSales.Average(s => s.Price);
            decimal sumOfSquares = filteredSales.Sum(s => (s.Price - average) * (s.Price - average));
            return (decimal)Math.Sqrt((double)(sumOfSquares / filteredSales.Count));
        }

        public static decimal CalculateStandardDeviationEarningsPerYear(List<Sales> salesList, int startYear, int endYear)
        {
            var filteredSales = salesList.Where(s => s.Date.Year >= startYear && s.Date.Year <= endYear).ToList();
            if (filteredSales.Count == 0) return 0;
            decimal average = filteredSales.Average(s => s.Price);
            decimal sumOfSquares = filteredSales.Sum(s => (s.Price - average) * (s.Price - average));
            return (decimal)Math.Sqrt((double)(sumOfSquares / filteredSales.Count));
        }
    }
}