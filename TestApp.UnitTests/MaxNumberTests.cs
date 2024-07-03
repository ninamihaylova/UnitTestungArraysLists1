using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> numbers = new List<int>() { 10 };
        int expected = 10;

        // Act
        int actual = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(actual,Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int>() { 10, 20, 500, 1, 35 };
        int expected = 500;

        // Act
        int actual = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(actual,Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int>() { -10, -20, -500, -1, -35 };
        int expected = -1;

        // Act
        int actual = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(actual,Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int>() { 10, -20, -500, 1, 35 };;
        int expected = 35;

        // Act
        int actual = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(actual,Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, -30, 300, 300, 95 };;
        int expected = 300;

        // Act
        int actual = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(actual,Is.EqualTo(expected));
    }
}
