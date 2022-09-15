namespace Assignment1.Tests;

public class IteratorTests
{
    [Fact]
    public void FlattenGivenListOfListOfIntsReturnsListOfInts()
    {
        List<List<int>> list = new();
        for (int i = 0; i < 10; i++)
        {
            list.Add(new List<int> { 1, 2 });
        }
        IEnumerable<int> output = Iterators.Flatten(list);
        Assert.Equal(new List<int> { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 }, output);
    }

    [Fact]
    public void FilterGivenListOfIntsReturnsListOfEvenInts()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

        Predicate<int> even = Even;
        bool Even(int i) => i % 2 == 0;

        Assert.Equal(new List<int> { 2, 4, 6 }, Iterators.Filter(list, even));
    }
}