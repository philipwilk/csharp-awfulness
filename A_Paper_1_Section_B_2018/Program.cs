void checkIsPrime(Int64 number)
{
  if (number <= 1)
  {
    Console.WriteLine("Number not greater than 1");
    return;
  }
  for (int i = 2; i <= Math.Sqrt(number); i++)
  {
    if (number % i == 0)
    {
      Console.WriteLine("{0} is not prime", number);
      return;
    }
  }
  Console.WriteLine("{0} is prime", number);

}

Int64 GetNum()
{
  Console.WriteLine("Enter a number to check for primality");
  var raw_input = Console.ReadLine()?.ToString();
  Int64 number;
  if (Int64.TryParse(raw_input, out number))
  {
    return number;
  }
  else
  {
    Console.WriteLine("Invalid value of {0} entered. Please try again.");
    return GetNum();
  }
}

void loop()
{
  Int64 num = GetNum();
  checkIsPrime(num);
  Console.WriteLine("Another number or end program: END or anything else to be promped for another number");
  string input = Console.ReadLine()!.ToString();
  if (input.ToLower() == "end")
  {
    return;
  }
  else
  {
    loop();
  }
}

loop();
