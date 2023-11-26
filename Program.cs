void f(int x)
{

    Console.WriteLine(x);
    x = x+1;
    Console.WriteLine(x);
}


int x = 10;
Console.WriteLine(x);
f(x);
Console.WriteLine(x);