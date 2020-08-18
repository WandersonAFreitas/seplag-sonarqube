using Xunit;

namespace PrimeService.Tests
{
    public class Tutorial_IsPrimeShould
    {
        private readonly Tutorial _tutorial;

        public Tutorial_IsPrimeShould() 
        { 
            _tutorial = new Tutorial();
        } 

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _tutorial.IsPrime(value);
            
            Assert.False(result, $"{value} should not be prime");
        }
    }
}