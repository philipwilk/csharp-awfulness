Console.WriteLine("Enter plaintext string: ");
var raw = Console.ReadLine();
string encoded = "";
char previous = new char();
int number = 0;
foreach (char letter in raw!)
{
  if (previous != letter && number != 0)
  {
    encoded += previous + " " + number.ToString() + " ";
    number = 0;
  }
  previous = letter;
  number += 1;
}
encoded += previous + " " + number.ToString();
Console.WriteLine("Compressed text: {0}", encoded);