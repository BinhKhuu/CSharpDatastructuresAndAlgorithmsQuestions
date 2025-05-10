using System.Text.RegularExpressions;

namespace CSharpDatastructuresAndAlogrithmsQuestions.StringQuestions;

public class StringIsPalindrome
{
    public StringIsPalindrome()
    {
        
    }

    public bool WordIsPalindromeFor(string word)
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
    
    public bool WordIsPalindromeWhile(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
            return true; // Handle empty or whitespace-only inputs early

        word = Regex.Replace(word.ToLower(), @"\s+|[\p{P}]", ""); // Combine cleanup steps

        int left = 0, right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
                return false;
            left++;
            right--;
        }

        return true;
    }
}