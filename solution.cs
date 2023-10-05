static void Main(string[] args)
{
    string[] words = { "cat", "dog", "tac", "god", "good", "act" };
    var groupedAnagrams = GroupAnagrams(words);

    foreach (var group in groupedAnagrams)
    {
        Console.WriteLine(string.Join(", ", group));
    }
}