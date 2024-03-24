// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static string ReverseCase(string input)
{
    char[] result = new char[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        char nowChar = input[i];
        if (char.IsUpper(nowChar))
            result[i] = char.ToLower(nowChar);
        else if (char.IsLower(nowChar))
            result[i] = char.ToUpper(nowChar);
        else
            result[i] = nowChar;
    }
    return new string(result);
}


Console.WriteLine(ReverseCase(" Nikola Avramovski AsDFGhjJK"));