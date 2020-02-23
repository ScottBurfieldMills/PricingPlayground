using PriceStuff.Steps;
using Xunit;

namespace PriceStuff.Tests.Steps
{
    public class GstPricingTest
    {
        [Fact]
        public void ItAddsGstToPrice()
        {
            var option = new Option();
            var gstPricing = new GstPricing();

            var expected = 11.5M;
            var actual = gstPricing.Calculate(option, 10);

            Assert.Equal(expected, actual);
        }
    }
}
