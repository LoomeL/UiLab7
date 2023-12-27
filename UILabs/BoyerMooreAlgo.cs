namespace UILabs;

public class BoyerMooreAlgo
{
    private readonly int[] _badMatchTable;

    public BoyerMooreAlgo(string pattern)
    {
        _badMatchTable = new int[256];
        for (int i = 0; i < _badMatchTable.Length; i++)
        {
            _badMatchTable[i] = pattern.Length;
        }

        for (int i = 0; i < pattern.Length - 1; i++)
        {
            _badMatchTable[pattern[i]] = pattern.Length - 1 - i;
        }
    }

    public List<int> Search(string text, string pattern)
    {
        List<int> occurrences = new List<int>();
        int textLength = text.Length;
        int patternLength = pattern.Length;
        int i = 0;

        while (i <= textLength - patternLength)
        {
            int j = patternLength - 1;

            while (j >= 0 && pattern[j] == text[i + j])
            {
                j--;
            }

            if (j < 0)
            {
                occurrences.Add(i);
                i += patternLength;
            }
            else
            {
                i += _badMatchTable[text[i + patternLength - 1]];
            }
        }

        return occurrences;
    }

}