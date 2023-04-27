Dictionary<char, int> first_word_letters, second_word_letters;
Console.WriteLine("Enter first word");
string first_word = Console.ReadLine()!.ToString();
Console.WriteLine("Enter second word");
string second_word = Console.ReadLine()!.ToString();

first_word_letters = new Dictionary<char, int>();
second_word_letters = new Dictionary<char, int>();

// count letters in first word
foreach (char letter in first_word)
{
  first_word_letters[letter] = first_word_letters.ContainsKey(letter) ? first_word_letters[letter] + 1 : 1;
}

// count letters in second word
foreach (char letter in second_word)
{
  second_word_letters[letter] = second_word_letters.ContainsKey(letter) ? second_word_letters[letter] + 1 : 1;
}

// Each char in the first word must occur in the second word at least the same number of times
bool firstWordFitsInSecond = true;
foreach (KeyValuePair<char, int> pair in first_word_letters)
{
  if (!second_word_letters.ContainsKey(pair.Key) || second_word_letters[pair.Key] < pair.Value)
  {
    firstWordFitsInSecond = false;
  }
}

if (firstWordFitsInSecond)
{
  Console.WriteLine("The word {0} can be made from the word {1}.", first_word, second_word);
}
else
{
  Console.WriteLine("The word {0} cannot be made from the word {1}", first_word, second_word);
}