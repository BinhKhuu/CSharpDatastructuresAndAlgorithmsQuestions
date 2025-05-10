namespace CSharpDatastructuresAndAlogrithmsQuestions.StringQuestions;

public class TwoWordsAreAnagrams
{
    public TwoWordsAreAnagrams(){}

    public bool AreTheyAnagrams(string word1, string word2)
    {
        if(word1.Length != word2.Length) return false;
        if(word1.Equals(word2, StringComparison.InvariantCultureIgnoreCase)) return true;
        
        var sortedWord1 = new string(word1.ToLower().OrderBy(w => w).ToArray());
        var sortedWord2 = new string(word2.ToLower().OrderBy(w => w).ToArray());

        return sortedWord1.Equals(sortedWord2, StringComparison.InvariantCultureIgnoreCase);
    }
}