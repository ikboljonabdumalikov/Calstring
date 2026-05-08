
string answer = "yes"; // Boshlanishida "yes" deb belgilaymiz

// Dastur faqat foydalanuvchi "no" deb yozmaguncha ishlaydi
while (answer != "no")
{
    Console.WriteLine("\nIfodani kiriting (masalan, 10+5-2):");
    string input = Console.ReadLine().Replace(" ", "");

    int result = 0;
    int currentNumber = 0;
    char lastOp = '+';

    // Hisoblash qismi
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

    Console.WriteLine("Natija: " + result);

    // Siklni to'xtatish yoki davom ettirishni so'raymiz
    Console.Write("Yana davom etamizmi? (yes/no): ");
    answer = Console.ReadLine().ToLower();
}

Console.WriteLine("Dastur tugadi. Sog' bo'ling!");