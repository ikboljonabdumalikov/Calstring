
string answer = "yes"; // Boshlanishida "yes" deb belgilaymiz

// Dastur faqat foydalanuvchi "no" deb yozmaguncha ishlaydi
while (answer != "no")
{
    string input = ReadInput();
    int result = AddNumbers(input);
    Console.WriteLine("Natija: " + result);
    answer = ReadAnswer();
}

Console.WriteLine("Dastur tugadi. Sog' bo'ling!");

static string ReadInput()
{
    Console.WriteLine("\nIfodani kiriting (masalan, 10+5-2):");
    string inputLine = Console.ReadLine();
    return (inputLine == null ? "" : inputLine.Replace(" ", ""));
}

static int AddNumbers(string input)
{
    int result = 0;
    int currentNumber = 0;
    char lastOp = '+';

    for (int i = 0; i < input.Length; i++)
    {
        char character = input[i];

        if (char.IsDigit(character))
        {
            currentNumber = currentNumber * 10 + (character - '0');
        }

        if (!char.IsDigit(character) || i == input.Length - 1)
        {
            if (lastOp == '+') result += currentNumber;
            else if (lastOp == '-') result -= currentNumber;

            lastOp = character;
            currentNumber = 0;
        }
    }

    return result;
}

static string ReadAnswer()
{
    Console.Write("Yana davom etamizmi? (yes/no): ");
    string answerLine = Console.ReadLine();
    return (answerLine == null ? "no" : answerLine.ToLower());
}