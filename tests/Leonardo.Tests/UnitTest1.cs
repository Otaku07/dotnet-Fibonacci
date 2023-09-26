namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async void Test1()
    {
        var results = await Fibonacci.RunAsync(new string[] { "44", "22", "33" });
        Assert.Equal(3, results.Count);

    }
}