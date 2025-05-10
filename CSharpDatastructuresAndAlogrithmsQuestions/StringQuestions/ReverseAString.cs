namespace UnitTests.StringQuestionTests;

public class ReverseAString
{
    public ReverseAString()
    {
        
    }

    public string ReverseAStringIterative(string word)
    {
        if(word.Length <= 1)
            return word;

        var reversedWord = String.Empty;
        for (var i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        return reversedWord;
    }

    public string ReverseAStringRecursive(string word)
    {
        var reversedWord = _ReverseAStringRecursive(word);
        return reversedWord;
    }
    
    private string _ReverseAStringRecursive(string word)
    {
        if(word.Length == 0)
            return word;
        return _ReverseAStringRecursive(word.Substring(1)) + word[0];
    }
}