namespace LeetCode.Tests;

public class _8MyAtoiTests
{
    private Solution _solution;

    [SetUp]
    public void Init()
    {
        _solution = new();
    }

    [Test]
    public void Test1()
    {
        Assert.That(_solution.MyAtoi("42"), Is.EqualTo(42));
    }

    [Test]
    public void Test2()
    {
        Assert.That(_solution.MyAtoi("1337c0d3"), Is.EqualTo(1337));
    }
}
