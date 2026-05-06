
Console.WriteLine("Ifodani kiriting (masalan, 1+3-1+5+8):");
string input = Console.ReadLine();

int result = 0;
int currentNumber = 0;
char lastOp = '+';
int i = 0;

while (i < input.Length)
{
    char character = input[i];

    if (character >= '0' && character <= '9')
    {
        currentNumber = currentNumber * 10 + (character - '0');
    }

    if (character == '+' || character == '-' || i == input.Length - 1)
    {
        if (lastOp == '+')
        {
            result += currentNumber;
        }
        else if (lastOp == '-')
        {
            result -= currentNumber;
        }

        lastOp = character;
        currentNumber = 0;
    }
    i++;
}
Console.WriteLine(result);
