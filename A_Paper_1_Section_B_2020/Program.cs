Console.WriteLine("How many digits would you like to enter?");
var digitNum = Console.ReadLine()!.ToString();

enterDigits:
Console.WriteLine("Enter your digits:");
var digits = Console.ReadLine()!.ToString();
if (digits.Length != Int32.Parse(digitNum))
{
  goto enterDigits;
}

Dictionary<char, int> numberOfDigits = new Dictionary<char, int> { };
foreach (char digit in digits)
{
  numberOfDigits[digit] = numberOfDigits.TryGetValue(digit, out int val) ? val + 1 : 1;
}

var ordered = (from i in numberOfDigits orderby i.Value descending select i).ToList();
Console.WriteLine("{0}", ordered[0].Value == ordered[1].Value ? "Data was multimodal" : ordered[0].Value);
