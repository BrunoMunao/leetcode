bool CanConstruct(string ransomNote, string magazine)
{
	Dictionary<char, int> letterCount = new Dictionary<char, int>();
	foreach (var letter in magazine)
	{
		if (letterCount.ContainsKey(letter))
			letterCount[letter]++;
		else
			letterCount[letter] = 1;
	}
	foreach (var letter in ransomNote)
	{
		if (letterCount.ContainsKey(letter) && letterCount[letter] > 0)
			letterCount[letter]--;
		else
			return false;
	}

	return true;
}

Console.WriteLine(CanConstruct("a", "b"));

