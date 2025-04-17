namespace synactics_test

{
    public class Sales
    {
        public DateOnly Date { get; set; }
        public decimal Price { get; set; }
        //public decimal Total { get; set; }


        public Sales(DateOnly date, decimal price)
        {
            Date = date; 
            Price = price;
            //Total = quantity * price;
        }
    }
}