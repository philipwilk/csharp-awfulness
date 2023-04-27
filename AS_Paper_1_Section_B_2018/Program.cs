// See https://aka.ms/new-console-template for more information
int number = 0;
while (number < 1 || number > 10)
{
  Console.WriteLine("Enter a positive whole number: ");
  number = Int32.Parse(Console.ReadLine());
  if (number > 10)
  {
    Console.WriteLine("Number too large.");
  }
  else if (number < 1)
  {
    Console.WriteLine("Not a positive whole number.");
  }
}
int c = 1;
for (int k = 0; k <=   number - 1; k++)
{
  Console.WriteLine(c);
  c = (c * (number - 1 - k)) / (k + 1);
}