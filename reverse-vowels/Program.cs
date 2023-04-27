List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
string word = Console.ReadLine()!.ToString();
List<char> vowel_order = new List<char>();

foreach (char letter in word)
{
  if (vowels.Contains(letter))
  {
    vowel_order.Add(letter);
  }
}
vowel_order.Reverse();

string new_word = "";
int vowel_count = 0;
foreach (char letter in word)
{
  if (vowels.Contains(letter))
  {
    new_word += vowel_order[vowel_count];
    vowel_count++;
  }
  else
  {
    new_word += letter;
  }
}

Console.WriteLine(new_word);
