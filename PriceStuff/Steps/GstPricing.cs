namespace PriceStuff.Steps
{
    public class GstPricing : IPriceStep
    {
        public decimal Calculate(Option option, decimal currentPrice)
        {
            return currentPrice + (currentPrice * (decimal) 0.15);
        }
    }
}
