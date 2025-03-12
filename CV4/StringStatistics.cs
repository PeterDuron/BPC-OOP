using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class StringStatistics
{
    private string text;
    private string[] words;

    public StringStatistics(string text)
    {
        this.text = text;
        words = ExtractWords(text);
    }

    private string[] ExtractWords(string text)
    {
        return Regex.Matches(text.ToLower(), @"\b\w+\b")
                    .Select(m => m.Value)
                    .ToArray();
    }

    public int WordCount() => words.Length;

    public int LineCount() => text.Split('\n').Length;

    public int SentenceCount()
    {
        return Regex.Matches(text, @"(?<=[.!?])\s+(?=[A-Z]|$)").Count + 1;
    }

    public string[] LongestWords()
    {
        int maxLength = words.Max(w => w.Length);
        return words.Where(w => w.Length == maxLength).ToArray();
    }

    public string[] ShortestWords()
    {
        int minLength = words.Min(w => w.Length);
        return words.Where(w => w.Length == minLength).ToArray();
    }

    public string[] MostFrequentWords()
    {
        return words.GroupBy(w => w)
                    .OrderByDescending(g => g.Count())
                    .ThenBy(g => g.Key)
                    .Take(1)
                    .Select(g => g.Key)
                    .ToArray();
    }

    public string[] SortedWords()
    {
        return words.OrderBy(w => w).ToArray();
    }


}


