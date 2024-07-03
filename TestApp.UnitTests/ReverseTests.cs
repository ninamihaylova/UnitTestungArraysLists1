using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] numbers = new[] { 42 };
        // Act
        string actual=Reverse.ReverseArray(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] numbers = new[] { 10, 20, -30 };

         // Act
        string actual=Reverse.ReverseArray(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo("-30,20,10"));
    }
}
