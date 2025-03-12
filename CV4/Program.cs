
using System.Runtime.CompilerServices;

string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
        + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
        + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
        + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
        + "posledni veta!";

StringStatistics str = new StringStatistics(testovaciText);

Console.WriteLine(testovaciText+'\n');
Console.WriteLine(str.WordCount());
Console.WriteLine(str.LineCount());
Console.WriteLine(str.SentenceCount());
Console.WriteLine(string.Join(", ",str.LongestWords()));
Console.WriteLine(string.Join(", ",str.ShortestWords()));
Console.WriteLine(string.Join(", ",str.MostFrequentWords()));    
Console.WriteLine(string.Join(", ",str.SortedWords()));