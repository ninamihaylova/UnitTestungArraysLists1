using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> numbers = new();
        string expected = string.Empty;

        // Act
        string actual =AdjacentEqual.Sum(numbers) ;

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> numbers = new() { 2, 3, 7, 5, 8 };
        string expected = "2 3 7 5 8";

        // Act
        string actual =AdjacentEqual.Sum(numbers) ;

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new() { 2, 3, 7, 5, 8 };
        string expected = "5 7 5 8";

        // Act
        string actual =AdjacentEqual.Sum(numbers) ;

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> numbers = new() { 2, 2, 3, 3, 7, 7, 5, 5 };
        string expected = "4 6 14 10";

        // Act
        string actual =AdjacentEqual.Sum(numbers) ;

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new() { 2, 3, 7, 5 };
        string expected = "5 7 5";
        // Act
        string actual =AdjacentEqual.Sum(numbers) ;

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new() {2, 3,  7, 5, 5};
        string expected = "2 3 7 10";

        // Act
        string actual =AdjacentEqual.Sum(numbers) ;

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new() { 3, 5, 6, 9};
        string expected = "3 11 9";

        // Act
        string actual =AdjacentEqual.Sum(numbers) ;

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
