using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "Anna", "Jonathan", "Canada", "Andrew", "Banana", "Alan" };
        Console.WriteLine("Список строк для поиска:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        while (true)
        {
            Console.WriteLine("\nВведите строку для поиска (или 'exit' для завершения):");
            string input = Console.ReadLine();
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

            List<string> results = SearchStrings(names, input);
            if (results.Count > 0)
            {
                Console.WriteLine("Найдены строки:");
                foreach (var result in results)
                {
                    Console.WriteLine(HighlightMatch(result, input));
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено.");
            }
        }
    }

    static List<string> SearchStrings(List<string> list, string search)
    {
        return list.Where(s => s.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
    }

    static string HighlightMatch(string text, string search)
    {
        int index = text.IndexOf(search, StringComparison.OrdinalIgnoreCase);
        if (index >= 0)
        {
            string match = text.Substring(index, search.Length);
            return text.Replace(match, $"\u001b[31m{match}\u001b[0m");
        }
        return text;
    }
}
