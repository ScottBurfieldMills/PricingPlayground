namespace PriceStuff.Steps
{
    public class StandardPricing : IPriceStep
    {
        public decimal Calculate(Option option, decimal currentPrice)
        {
            if (option.SpecialPrice.HasValue && option.SpecialPrice.Value > 0)
            {
                return option.SpecialPrice.Value;
            }

            if (option.SalePrice.HasValue && option.SalePrice.Value > 0)
            {
                return option.SalePrice.Value;
            }

            return option.ListPrice ?? 9999999M;
        }
    }
}
