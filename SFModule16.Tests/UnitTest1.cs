namespace SFModule16.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SubtractionTest()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Subtraction(300, 10), Is.EqualTo(290));
    }
}