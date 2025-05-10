using CSharpDatastructuresAndAlogrithmsQuestions.StringQuestions;

namespace UnitTests.StringQuestionTests;

public class TwoWordsAreAnagramsTests
{
    private TwoWordsAreAnagrams _helper { get; set; }
    
    [SetUp]
    public void Setup()
    {
        _helper = new TwoWordsAreAnagrams();
    }

    public static IEnumerable<object[]> TwoWordsAnagramsTestCases()
    {
        yield return new object[] { "hello", "hello", true };
        yield return new object[] { "Silent", "Listen", true };
        yield return new object[] { "Post", "Opts", true };
        yield return new object[] { "rat", "tar", true };
        yield return new object[] { "dormitory", "dirty room", false }; // false because its two words
        yield return new object[] { "apple", "apples", false };
        yield return new object[] { "stone", "ton", false };
        yield return new object[] { "hello", "olell", false };
    }
    
    [TestCaseSource(nameof(TwoWordsAnagramsTestCases))]
    public void TwoWordsAreAnagramsTest(string word1, string word2, bool expected)
    {
        var result =_helper.AreTheyAnagrams(word1, word2);
        Assert.That(result, Is.EqualTo(expected));
    }
}