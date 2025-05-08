
using CSharpDatastructuresAndAlogrithmsQuestions.StringQuestions;

namespace UnitTests.StringQuestionTests;

public class DuplicateCharactersInAStringTests
{
    private DuplicateCharactersInAString helper { get; set; }
    [SetUp]
    public void Setup()
    {
        this.helper = new DuplicateCharactersInAString();
    }
    
    public static IEnumerable<object[]> OrderedDuplicateStringTestCases()
    {
        yield return new object[] { "hello", "l" };      // 'l' appears twice
        yield return new object[] { "mississippi", "isp" }; // 'i', 's' and 'p' appear multiple times
        yield return new object[] { "banana", "an" };
    }
    

    [TestCaseSource(nameof(OrderedDuplicateStringTestCases))]
    public void GetsDuplicatedCharactersInOrderOfWord(string key, string result)
    {
        var duplicatedCharacters = helper.GetDuplicatedCharactersInWordOrder(key);
        Assert.That(duplicatedCharacters, Is.EqualTo(result));
    }
    
    public static IEnumerable<object[]> RemoveDuplicateStringTestCases()
    {
        yield return new object[] { "hello", "helo" };      // 'l' appears twice
        yield return new object[] { "mississippi", "misp" }; // 'i', 's' and 'p' appear multiple times
        yield return new object[] { "banana", "ban" };
    }
    [TestCaseSource(nameof(RemoveDuplicateStringTestCases))]
    public void RemovesDuplicatedCharactersInWord(string key, string result)
    {
        var duplicatedCharacters = helper.RemoveDuplicateCharacters(key);
        Assert.That(duplicatedCharacters, Is.EqualTo(result));
    }
}