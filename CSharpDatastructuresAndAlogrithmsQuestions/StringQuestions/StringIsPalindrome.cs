using System.Text.RegularExpressions;

namespace CSharpDatastructuresAndAlogrithmsQuestions.StringQuestions;

public class StringIsPalindrome
{
    public StringIsPalindrome()
    {
        
    }

    public bool WordIsPalindrome(string word)
    {
        word = word.ToLower();
        word = Regex.Replace(word, @"\s+", "");
        word = Regex.Replace(word, @"[\p{P}]", "");
        if (word.Length == 0 || word.Length == 1)
            return true;
        
        var isPalindrome = false;
        for (var i = 1; i < word.Length; i++)
        {
            if (word[i] != word[word.Length - i - 1])
                return false;
            
            if(i == word.Length - 1)
                isPalindrome = true;
        }
        
        return isPalindrome;
    }
}