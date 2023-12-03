char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
string str = "";

foreach(char c in charArray)
{
    str += c;
}

Console.WriteLine(str);