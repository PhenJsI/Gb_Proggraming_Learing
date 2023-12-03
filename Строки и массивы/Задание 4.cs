string input = Console.ReadLine();
string result = ReverseString(input);
Console.WriteLine(result);


string ReverseString(string input)
{
    string[] words = input.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}