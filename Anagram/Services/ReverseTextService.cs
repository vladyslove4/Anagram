namespace Anagram.Services;

internal class ReverseTextService : IReverter
{
    public string ReverseText(string data)
    {
        if (data == null)
        {
            throw new ArgumentNullException(nameof(data));
        }
        string[] words = data.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 1)
            {
                words[i] = ReverseWord(words[i]);
            }
        }

        return string.Join(' ', words);
    }

    private string ReverseWord(string data)
    {
        char[] chars = data.ToCharArray();
        int j = data.Length - 1;
        for (int i = 0; i < data.Length; i++)
        {
            if (char.IsLetter(data[i]))
            {
                while (!char.IsLetter(data[j]))
                    j--;
                chars[j] = data[i];
                j--;
            }
        }

        return new string(chars);
    }
}