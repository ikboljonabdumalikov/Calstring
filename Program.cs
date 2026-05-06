
Console.WriteLine("Ifodani kiriting (masalan, 1+3-1+5+8):");
string input = Console.ReadLine();

int result = 0;
int currentNumber = 0;
char lastOp = '+';
int i = 0;

while (i < input.Length)
{
    char c = input[i];

    if (c >= '0' && c <= '9')
    {
        currentNumber = currentNumber * 10 + (c - '0');
    }

    if (c == '+' || c == '-' || i == input.Length - 1)
    {
        if (lastOp == '+')
        {
            result += currentNumber;
        }
        else if (lastOp == '-')
        {
            result -= currentNumber;
        }

        lastOp = c;
        currentNumber = 0;
    }
    i++;
}