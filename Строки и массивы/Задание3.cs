string input = Console.ReadLine();
bool ispalindrom = Palidnrom(input);
Console.WriteLine(ispalindrom ? "Да":"Нет");


bool Palidnrom (string input)
{
    string normalized = new
    string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
}