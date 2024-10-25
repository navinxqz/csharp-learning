string[] words = { "lol", "world", "racecar" ,"talented", "deified", "tent", "tenet" };

foreach (string word in words)
{
    Console.WriteLine($"{word} is a palindrome: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - i - 1])
        {
            return false;
        }
    }return true;
}