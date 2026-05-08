
Console.WriteLine("Ifodani kiriting (masalan, 12+34-5+100):");
string input = Console.ReadLine();

if (input == null || input == "")
{
    Console.WriteLine("Iltimos, ifodani kiriting.");
    return;
}

input = input.Replace(" ", ""); // Agar foydalanuvchi bo'sh joy kiritgan bo'lsa olib tashlaymiz.

int result = 0;
int currentNumber = 0;
char lastOp = '+';

for (int i = 0; i < input.Length; i++)
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
            result = result + currentNumber;
        }
        else
        {
            result = result - currentNumber;
        }

        lastOp = character;
        currentNumber = 0;
    }
}

Console.WriteLine("Natija: " + result);
