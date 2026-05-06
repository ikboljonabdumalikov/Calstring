
bool isRunning = true;
while (isRunning)
{
    Console.Write("\nFaqat + va - amallari bor misol kiriting: ");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input)) continue;

    int i = 0;
    // 1. Birinchi sonni ajratib olish
    string tempNum = "";
    while (i < input.Length && (input[i] >= '0' && input[i] <= '9'))
    {
        tempNum += input[i];
        i++;
    }
    double result = double.Parse(tempNum);

    // 2. Qolgan amallarni bajarish
    while (i < input.Length)
    {
        char op = input[i]; // Amallarni olamiz (+ yoki -)
        i++;

        string nextNumStr = "";
        while (i < input.Length && (input[i] >= '0' && input[i] <= '9'))
        {
            nextNumStr += input[i];
            i++;
        }

        if (nextNumStr != "")
        {
            double nextNum = double.Parse(nextNumStr);
            if (op == '+') result += nextNum;
            else if (op == '-') result -= nextNum;
        }
    }

    Console.WriteLine("Javob: " + result);

    Console.Write("\nYana (ha/yo'q): ");
    if (Console.ReadLine().ToLower() != "ha") isRunning = false;
}
