using Assignment2_SM_MP;
using NUnit.Framework;
namespace CircleTests;

public class Tests
{
    private Circle circle;
    [SetUp]
    public void Setup()
    {
        //Arrange
        circle = new Circle();
    }


    //test cases on GetRadius
    [Test]
    public void TestGetRadius()
    {
        //Arrange
        Circle c = new Circle(5);
        int expected = 5;

        //Act
        int actual = c.GetRadius();

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test] public void TestGetRadius2()
    {
        Circle c = new Circle(10);
        int expected = 10;
        int actual = c.GetRadius();
        Assert.AreEqual(expected, actual);
    }

    [Test] public void TestGetRadius3()
    {
        Circle c = new Circle(15);
        int expected = 15;
        int actual = c.GetRadius();
        Assert.AreEqual(expected, actual);
    }


    //test cases on setRadius
    [Test] public void TestSetRadius()
    {
        circle.SetRadius(10);
        int expected = 10;
        int actual = circle.GetRadius();
        Assert.AreEqual(expected, actual);
    }

    [Test] public void TestSetRadius2()
    {
        circle.SetRadius(15);
        int expected = 15;
        int actual = circle.GetRadius();
        Assert.AreEqual(expected, actual);
    }

    [Test] public void TestSetRadius3()
    {
        circle.SetRadius(5);
        int expected = 5;
        int actual = circle.GetRadius();
        Assert.AreEqual(expected, actual);
    }


    //tests on getCircumference
    [Test] public void TestGetCircumference()
    {
        Circle c = new Circle(5);
        double expected = 31.42;
        double actual = c.GetCircumference();
        Assert.AreEqual(expected, actual, 0.05);
    }

    [Test] public void TestGetCircumference2() {
        circle.SetRadius(50);
        double expected = 314.16;
        double actual = circle.GetCircumference();
        Assert.AreEqual(expected, actual, 0.01);
    }

    [Test] public void TestGetCircumference3()
    {
        Circle c = new Circle(2);
        double expected = 12.57;
        double actual = c.GetCircumference();
        Assert.AreEqual(expected, actual, 0.02);
    }


   

    [TearDown] public void Teardown()
    {
        circle = null;
    }


}