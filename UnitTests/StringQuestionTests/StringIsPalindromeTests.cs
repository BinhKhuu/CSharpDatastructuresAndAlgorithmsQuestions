using CSharpDatastructuresAndAlogrithmsQuestions.StringQuestions;

namespace UnitTests.StringQuestionTests;

public class StringIsPalindromeTests
{
    private StringIsPalindrome _helper { get; set; }

    [SetUp]
    public void Setup()
    {
        _helper = new StringIsPalindrome();
    }
    
    public static IEnumerable<object[]> WordsInAStringTestCases()
    {
        yield return new object[] { "racecar", true };      // 'l' appears twice
        yield return new object[] { "abba", true };      // 'l' appears twice
        yield return new object[] { "aba", true };      // 'l' appears twice
        yield return new object[] { "hello", false };      // 'l' appears twice
        yield return new object[] { "12345", false };      // 'l' appears twice
        yield return new object[] { "a", true };      // 'l' appears twice
        yield return new object[] { " ", true };      // 'l' appears twice
        yield return new object[] { "RaceCar", true };      // 'l' appears twice
        yield return new object[] { "A man a plan a canal Panama", true };      // 'l' appears twice
        yield return new object[] { "Madam, I'm Adam", true };      // 'l' appears twice
    }

    [TestCaseSource(nameof(WordsInAStringTestCases))]
    public void IsPalindrome(string word, bool expected)
    {
        var result = _helper.WordIsPalindrome(word);
        Assert.That(result, Is.EqualTo(expected));        
    }
}