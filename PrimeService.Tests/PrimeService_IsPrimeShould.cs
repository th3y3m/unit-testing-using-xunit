namespace PrimeService.Tests;

public class PrimeService_IsPrimeShould
{
    [Fact]
    public void IsPrime_InputIs1_ReturnFalse()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(1);

        Assert.False(result, "1 should not be prime");
    }

    [Fact]
    public void IsPrime_InputIs5_ReturnTrue()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(5); // 5 is a prime number

        Assert.True(result, "5 should be prime");
    }

    [Fact]
    public void IsPrime_InputIsNegative_ReturnFalse()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(-1); // Negative numbers are not prime

        Assert.False(result, "-1 should not be prime");
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
    {
        var primeService = new PrimeService();
        var result = primeService.IsPrime(value);

        Assert.False(result, $"{value} should not be prime");
    }

    [Theory]
    [InlineData(1, false)] // 1 is not a prime number
    [InlineData(2, true)]  // 2 is a prime number
    [InlineData(3, true)]  // 3 is a prime number
    [InlineData(4, false)] // 4 is not a prime number
    [InlineData(5, true)]  // 5 is a prime number
    [InlineData(9, false)] // 9 is not a prime number
    [InlineData(-1, false)] // Negative numbers are not prime
    [InlineData(0, false)]  // 0 is not a prime number
    public void IsPrime_VariousInputs_ReturnsExpectedResult(int value, bool expected)
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(value);

        Assert.Equal(expected, result);
    }

}