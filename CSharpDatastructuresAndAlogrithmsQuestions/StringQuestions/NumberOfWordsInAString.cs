using System.Text.RegularExpressions;

namespace CSharpDatastructuresAndAlogrithmsQuestions.StringQuestions;

public class NumberOfWordsInAString
{
    public NumberOfWordsInAString(){}

    public int GetNumberOfWords(string words)
    {
        words = words.Trim();
        words = Regex.Replace(words, @"\s+", " ");
        if (words.Length == 0) return 0;
        if (words.Length == 1) return 1;

        return words.Split(" ").Length;

    }
}