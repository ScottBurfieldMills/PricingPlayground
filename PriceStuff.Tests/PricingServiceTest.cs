using System.Collections.Generic;
using Xunit;

namespace PriceStuff.Tests
{
    public class PricingServiceTest
    {
        [Fact]
        public void Stuff()
        {
            var priceService = new PriceService(new List<IPriceStep>
            {
                // Test that the steps are running to isolate the test
                // to ONLY the PricingService
                new MockStepOne(),
                new MockStepTwo()
            });

            var option = new Option();
            var actual = priceService.GetPrice(option);

            Assert.Equal(7M, actual);
        }
    }

    public class MockStepOne : IPriceStep
    {
        public decimal Calculate(Option option, decimal currentPrice)
        {
            return 5;
        }
    }

    public class MockStepTwo : IPriceStep
    {
        public decimal Calculate(Option option, decimal currentPrice)
        {
            return currentPrice + 2M;
        }
    }
}
