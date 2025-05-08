namespace CSharpDatastructuresAndAlogrithmsQuestions.StringQuestions;

public class DuplicateCharactersInAString
{
    public DuplicateCharactersInAString()
    {

    }

    /// <summary>
    /// Find Duplicated characters in a string in the same order as they appear in the original string
    /// </summary>
    /// <param name="word"></param>
    /// <returns>Duplicated string with each character in the same order as they are in the original string</returns>
    public string GetDuplicatedCharactersInWordOrder(string word)
    {
        var currentKey = new Dictionary<char, int>();
        
        for (var i = 0; i < word.Length; i++)
        {
            var isExistingKey = currentKey.TryGetValue(word[i], out var duplicateCount);
            if (isExistingKey)
            {
                currentKey[word[i]] = duplicateCount + 1;
            }
            else
            {
                currentKey.Add(word[i], 0);
            }
        }

        return string.Join("", currentKey.Where(x => x.Value > 0).Select(x => x.Key));
    }

    /// <summary>
    /// Removes duplicated characters from a string
    /// </summary>
    /// <param name="word">target word</param>
    /// <returns>string where duplicated characters have been removed from the original word</returns>
    public string RemoveDuplicateCharacters(string word)
    {
        string table = string.Empty;
        foreach (var value in word)
        {
            if (table.IndexOf(value) == -1)
            {
                table += value;
            }
        }
        return table;
    }

}