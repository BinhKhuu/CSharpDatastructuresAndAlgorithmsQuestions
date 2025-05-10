using CSharpDatastructuresAndAlogrithmsQuestions.StringQuestions;

namespace UnitTests.StringQuestionTests;

public class NumberOfWordsInAStringTests
{
    private NumberOfWordsInAString _helper;

    public NumberOfWordsInAStringTests()
    {
        _helper = new NumberOfWordsInAString();
    }
    [SetUp]
    public void Setup(){}
    
    public static IEnumerable<object[]> WordsInAStringTestCases()
    {
        yield return new object[] { "hello world", 2 };      // 'l' appears twice
        yield return new object[] { "test", 1}; // 'i', 's' and 'p' appear multiple times
        yield return new object[] { "a", 1}; // 'i', 's' and 'p' appear multiple times
        yield return new object[] { "", 0 };
        yield return new object[] { "\n", 0 };
        yield return new object[] { "\t", 0 };
        yield return new object[] { "\r\t\n", 0 };
        yield return new object[] { " Hello World ", 2 };
        yield return new object[] { " Hello\nWorld ", 2 };
        yield return new object[] { " Hello, World ", 2 };
        yield return new object[] { "123 456", 2 };
        yield return new object[] { "ello\tworld\nnew", 3 };
    }

    [TestCaseSource(nameof(WordsInAStringTestCases))]
    public void WordsInAStringTest(string word, int expected)
    {
        var result = _helper.GetNumberOfWords(word);
        Assert.That(result, Is.EqualTo(expected));
    }
}