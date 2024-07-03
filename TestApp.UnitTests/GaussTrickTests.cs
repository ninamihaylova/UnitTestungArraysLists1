using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();
        

        // Act
        List<int> actual = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, actual);
    }

    
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> numbers = new List<int>() { 4 };
        List<int> expected = new List<int>() { 4 };

        // Act
        List<int> actual= GaussTrick.SumPairs(numbers);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> numbers = new List<int>() { 4, 2, 12, 20 };
        List<int> expected = new List<int>() { 24, 14 };
        

        // Act
        List<int> actual = GaussTrick.SumPairs(numbers);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> numbers = new List<int>() { 2, 8, 10, 20, 25 };
        List<int> expected = new List<int>() { 27, 28, 10 };

        // Act
        List<int> actual = GaussTrick.SumPairs(numbers);

        // Assert
        CollectionAssert.AreEqual(expected,actual);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> numbers = new List<int>() { 5, 10, 20, 25, 40, 35 };
        List<int> expected = new List<int>() { 40, 50, 45 };

        // Act
        List<int> actual = GaussTrick.SumPairs(numbers);

        // Assert
        CollectionAssert.AreEqual(expected,actual);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> numbers = new List<int>() { 5, 10, 20, 25, 40, 35 };
        List<int> expected = new List<int>() { 40, 50, 45, 25 };

        // Act
        List<int> actual = GaussTrick.SumPairs(numbers);

        // Assert
        CollectionAssert.AreEqual(expected,actual);
    }
}
