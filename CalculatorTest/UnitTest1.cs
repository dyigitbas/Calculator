namespace BasicCalculatorTest;

using BasicCalculator.Controllers;

public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        var a = new BasicCalculatorController();
        var result = a.Add(1,3);
        Assert.Equal(4, result);
    }
}