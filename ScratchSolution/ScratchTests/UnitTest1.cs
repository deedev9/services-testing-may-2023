namespace ScratchTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
    [Fact]
    public void CanAddTenAndTwenty()
    {
        // Given - "Arrange"
        // You have to create the world from scratch here
        int a = 10, b = 20, answer;

        // When - "Act"
        answer = a + b;

        // Then - "Assert"
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(10, 20, 30)]
    public void CanAddOtherIntegers(int a, int b, int expected)
    {
        int answer = a + b;
        Assert.Equal(expected, answer);
    }
}