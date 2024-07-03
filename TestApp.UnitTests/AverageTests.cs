using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] numbers = { 42 };
        int expected = 42;

        // Act
        double actual = Average.CalculateAverage(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        double expected = 3.5;

        // Act
        double actual = Average.CalculateAverage(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] numbers = { -1, -2, -3, -4, -5, -6 };
        double expected = -3.5;

        // Act
        double actual = Average.CalculateAverage(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] numbers = new[] { 1, 2, 3, -5, 7 };
        double expected = 1.6;
        

        // Act
        double actual = Average.CalculateAverage(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
