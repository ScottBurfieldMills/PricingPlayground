using PriceStuff.Steps;
using Xunit;

namespace PriceStuff.Tests
{
    public class StandardPricingTest
    {
        [Fact]
        public void SpecialPriceHasPriorityOverSalePrice()
        {
            var option = new Option
            {
                SalePrice = 10,
                SpecialPrice = 5
            };

            var expected = 5;
            var actual = new StandardPricing().Calculate(option, 0);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SalePriceHasPriorityOverListPrice()
        {
            var option = new Option
            {
                ListPrice = 10.99M,
                SalePrice = 8.99M
            };

            var expected = 8.99M;
            var actual = new StandardPricing().Calculate(option, 0);

            Assert.Equal(expected, actual);
        }
    }
}
