namespace ReadOutNumb;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to read: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine(ReadNumber(number));
        }
        else
        {
            Console.WriteLine("Please enter a valid integer.");
        }
    }
    static string ReadNumber(int number)
    {
        string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (number >= 0 && number < 10)
        {
            return ones[number];
        }
        else if (number >= 10 && number < 20)
        {
            return teens[number - 10];
        }
        else if (number >= 20 && number < 100)
        {
            int tenPart = number / 10;
            int onePart = number % 10;
            return onePart == 0 ? tens[tenPart] : $"{tens[tenPart]} {ones[onePart]}";
        }
        else if (number >= 100 && number < 1000)
        {
            int hundredPart = number / 100;
            int remainder = number % 100;
            if (remainder == 0)
            {
                return $"{ones[hundredPart]} hundred";
            }
            else
            {
                return $"{ones[hundredPart]} hundred and {ReadNumber(remainder)}";
            }
        }
        else
        {
            return "out of ability";
        }
    }
}
