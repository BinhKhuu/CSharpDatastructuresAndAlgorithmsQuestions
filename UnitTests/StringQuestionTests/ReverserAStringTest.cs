namespace UnitTests.StringQuestionTests;

public class ReverserAStringTest
{
    private ReverseAString _helper { get; set; }
    [SetUp]
    public void Setup()
    {
        _helper = new ReverseAString();
    }
    
    public static IEnumerable<object[]> ReverseAStringTestCases()
    {
        yield return new object[] { "hello", "olleh" };
        yield return new object[] { "a", "a"};
        yield return new object[] { "", ""};
        yield return new object[] { "racecar", "racecar" };
        yield return new object[] { "HeLLo", "oLLeH"};
        yield return new object[] { " test ", " tset " };
        yield return new object[] { "hello world", "dlrow olleh"};
        yield return new object[] { "hello!", "!olleh"};
        yield return new object[] { "abc123", "321cba"};
    }

    [TestCaseSource(nameof(ReverseAStringTestCases))]
    public void ReverseAStringRecursiveTests(string input, string expected)
    {
        var result = _helper.ReverseAStringIterative(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCaseSource(nameof(ReverseAStringTestCases))]
    public void ReverseAStringIterativeTest(string input, string expected)
    {
        var result = _helper.ReverseAStringRecursive(input);
        Assert.That(result, Is.EqualTo(expected));
    }

}