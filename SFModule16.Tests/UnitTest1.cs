namespace SFModule16.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AdditionalTest()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Additional(300, 10), Is.EqualTo(310));
    }
    
    [Test]
    public void SubtractionTest()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Subtraction(300, 10), Is.EqualTo(290));
    }

    [Test]
    public void MultiplicationTest()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Miltiplication(3, 100), Is.EqualTo(300));
    }
    
    [Test]
    public void DivisionTest()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Division(300, 100), Is.EqualTo(3));
    }
    
    [Test]
    public void DivisionByZeroTest()
    {
        Calculator calculator = new Calculator();
        Assert.That(() => calculator.Division(300, 0), Throws.InstanceOf<DivideByZeroException>());
    }
}