using System.Collections.Generic;

namespace PriceStuff
{
    public class Option
    {
        public decimal? SalePrice { get; set; }
        public decimal? SpecialPrice { get; set; }
        public decimal? ListPrice { get; set; }
    }

    public interface IPriceStep
    {
        decimal Calculate(Option option, decimal currentPrice);
    }

    public class PriceService
    {
        private readonly List<IPriceStep> _steps;

        public PriceService(List<IPriceStep> steps)
        {
            _steps = steps;
        }

        public decimal GetPrice(Option option)
        {
            var price = 0M;

            foreach (var step in _steps)
            {
                price = step.Calculate(option, price);
            }
            
            // TODO Handle bad prices
            return price;
        }
    }
}
